using Domain.Entity;
using Domain.Enum;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PacienteController : Controller
    {
        public ActionResult Index()
        {
            var lista = new List<PacienteModel>();
            foreach (var item in new PacienteRepository().ListarTodos())
            {
                lista.Add(new PacienteModel()
                {
                    Codigo = item.Codigo,
                    Nome = item.Nome,
                    DataNascimento = item.DataNascimento.ToString("yyy-MM-dd"),
                    CPF = item.CPF,
                    Email = item.Email
                });
            }
            return View(lista);
        }

        // GET: /Paciente/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: /Paciente/Cadastrar
        [HttpPost]
        public ActionResult Cadastrar(PacienteModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Paciente p = new Paciente
                    {
                        Codigo = model.Codigo,
                        Nome = model.Nome,
                        DataNascimento = Convert.ToDateTime(model.DataNascimento),
                        CPF = model.CPF,
                        Email = model.Email
                    };

                    var tipoDeOperacao = (TipoOperacaoEnum)Session["TipoDeOperacao"];
                    if (tipoDeOperacao == TipoOperacaoEnum.Edicao)
                    {
                        new PacienteRepository().Editar(p);
                        ViewBag.Mensagem = String.Format("Paciente {0} atualizado com sucesso.", p.Codigo);
                    }
                    else
                    {
                        new PacienteRepository().Salvar(p);
                        ViewBag.Mensagem = String.Format("Paciente {0} cadastrado com sucesso.", p.Codigo);
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Mensagem = ex.Message;
                }
            }

            return View(model);
        }

        // GET: /Paciente/Detalhar/5
        public ActionResult Detalhar(Int32 codigo = 0)
        {
            return ObterEntidadeModelo(codigo);
        }

        // GET: /Paciente/Editar/5
        public ActionResult Editar(Int32 codigo = 0)
        {
            return ObterEntidadeModelo(codigo);
        }

        // GET: /Paciente/Excluir/5
        public ActionResult Excluir(Int32 codigo = 0)
        {
            var entity = new PacienteRepository().ObterPeloCodigo(codigo);

            if (entity == null)
            {
                return HttpNotFound();
            }
            else
            {
                var A = new PacienteModel()
                {
                    Codigo = codigo,
                    Nome = entity.Nome,
                    DataNascimento = entity.DataNascimento.ToShortDateString(),
                    CPF = entity.CPF,
                    Email = entity.Email
                };

                return View(A);
            }
        }

        // POST: /Paciente/Excluir/5
        [HttpPost, ActionName("Excluir")]
        public ActionResult ExclusaoConfirmada(Int32 codigo)
        {
            try
            {

                var repositorio = new PacienteRepository();

                var entity = repositorio.ObterPeloCodigo(codigo);

                if (entity != null)
                {
                    repositorio.Remover(entity);
                    Session.Add("Mensagem", String.Format("Paciente removido com sucesso.", entity.Codigo));
                }
            }
            catch (Exception ex)
            {
                Session.Add("Mensagem", ex.Message);
            }

            return RedirectToAction("Index");
        }

        private ActionResult ObterEntidadeModelo(Int32 codigo)
        {
            var entity = new PacienteRepository().ObterPeloCodigo(codigo);

            if (entity == null)
            {
                return HttpNotFound();
            }
            else
            {
                var A = new PacienteModel()
                {
                    Codigo = codigo,
                    Nome = entity.Nome,
                    DataNascimento = entity.DataNascimento.ToString("yyy-MM-dd"),
                    CPF = entity.CPF,
                    Email = entity.Email
                };

                Session.Add("TipoDeOperacao", TipoOperacaoEnum.Edicao);

                return View("Cadastrar", A);
            }
        }
    }
}
