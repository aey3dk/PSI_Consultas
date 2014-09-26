using DAL.Model;
using DAL.Repository;
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
            foreach (var paciente in new PacienteRepository().ListarTodos())
            {
                lista.Add(new PacienteModel()
                {
                    Id = paciente.Id,
                    Nome = paciente.Nome,
                    DataNascimento = paciente.Nascimento != null ? ((DateTime)paciente.Nascimento).ToString("yyy-MM-dd") : String.Empty,
                    CPF = paciente.CPF,
                    Email = paciente.Email
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
                        Id = model.Id,
                        Nome = model.Nome,
                        Nascimento = Convert.ToDateTime(model.DataNascimento),
                        CPF = model.CPF,
                        Email = model.Email
                    };

                    var tipoDeOperacao = (TipoOperacaoEnum)Session["TipoDeOperacao"];

                    new PacienteRepository().Inserir(p);
                    new PacienteRepository().Salvar();

                    ViewBag.Mensagem = String.Format("Paciente {0} {1} com sucesso.", p.Id, tipoDeOperacao == TipoOperacaoEnum.Alteracao ? "atualizado" : "cadastrado");
                }
                catch (Exception ex)
                {
                    ViewBag.Mensagem = ex.Message;
                }
            }

            return View(model);
        }

        // GET: /Paciente/Detalhar/5
        public ActionResult Detalhar(Int32 id = 0)
        {
            return ObterEntidadeModelo(id);
        }

        // GET: /Paciente/Editar/5
        public ActionResult Editar(Int32 id = 0)
        {
            return ObterEntidadeModelo(id);
        }

        // GET: /Paciente/Excluir/5
        public ActionResult Excluir(Int32 id = 0)
        {
            var paciente = new PacienteRepository().Obter(id);

            if (paciente == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(new PacienteModel()
                {
                    Id = id,
                    Nome = paciente.Nome,
                    DataNascimento = paciente.Nascimento != null ? ((DateTime)paciente.Nascimento).ToShortDateString() : String.Empty,
                    CPF = paciente.CPF,
                    Email = paciente.Email
                });
            }
        }

        // POST: /Paciente/Excluir/5
        [HttpPost, ActionName("Excluir")]
        public ActionResult ExclusaoConfirmada(Int32 id)
        {
            try
            {

                var repositorio = new PacienteRepository();

                var paciente = repositorio.Obter(id);

                if (paciente != null)
                {
                    repositorio.Excluir(paciente);
                    repositorio.Salvar();
                    Session.Add("Mensagem", String.Format("Paciente removido com sucesso.", paciente.Id));
                }
            }
            catch (Exception ex)
            {
                Session.Add("Mensagem", ex.Message);
            }

            return RedirectToAction("Index");
        }

        private ActionResult ObterEntidadeModelo(Int32 id)
        {
            var paciente = new PacienteRepository().Obter(id);

            if (paciente == null)
            {
                return HttpNotFound();
            }
            else
            {
                Session.Add("TipoDeOperacao", TipoOperacaoEnum.Alteracao);

                return View("Cadastrar", new PacienteModel()
                {
                    Id = id,
                    Nome = paciente.Nome,
                    DataNascimento = paciente.Nascimento != null ? ((DateTime)paciente.Nascimento).ToString("yyy-MM-dd") : String.Empty,
                    CPF = paciente.CPF,
                    Email = paciente.Email
                });
            }
        }
    }
}
