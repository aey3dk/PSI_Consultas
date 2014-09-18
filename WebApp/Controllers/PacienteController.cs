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
        private TipoOperacaoEnum TipoOperacao;
        private Boolean entidadeExiste;

        public ActionResult Index()
        {
            var lista = new List<PacienteModel>();
            foreach (var item in new PacienteRepository().ListarTodos())
            {
                lista.Add(new PacienteModel()
                {
                    Codigo = item.Codigo,
                    Nome = item.Nome,
                    DataNascimento = item.DataNascimento,
                    CPF = item.CPF,
                    Email = item.Email
                });
            }
            return View(lista);
        }
        //public ActionResult Cadastro()
        //{
        //    return View(new PacienteModel());
        //}

        //public ActionResult Cadastrar(PacienteModel model, String command)
        //{
        //    CarregarTipoOperacao(command);

        //    if (TipoOperacao == TipoOperacaoEnum.Buscar)
        //    {
        //        //model = Buscar(model.Codigo);
        //    }
        //    else if (TipoOperacao == TipoOperacaoEnum.Gravar)
        //    {
        //        ProcessarOperacao(model, TipoOperacao);
        //    }
        //    else if (TipoOperacao == TipoOperacaoEnum.Excluir)
        //    {
        //        ProcessarOperacao(model, TipoOperacao);
        //    }

        //    return View("Cadastro", model);
        //}

        //private void CarregarTipoOperacao(String command)
        //{
        //    if (command == TipoOperacaoEnum.Buscar.ToString()) { TipoOperacao = TipoOperacaoEnum.Buscar; }
        //    else if (command == TipoOperacaoEnum.Gravar.ToString()) { TipoOperacao = TipoOperacaoEnum.Gravar; }
        //    else if (command == TipoOperacaoEnum.Excluir.ToString()) { TipoOperacao = TipoOperacaoEnum.Excluir; }
        //}

        //private void ProcessarOperacao(PacienteModel model, TipoOperacaoEnum TipoOperacao)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            Paciente p = new Paciente
        //            {
        //                Codigo = entidadeExiste ? 0 : model.Codigo,
        //                Nome = model.Nome,
        //                DataNascimento = model.DataNascimento
        //            };

        //            if (TipoOperacao == TipoOperacaoEnum.Gravar)
        //            {
        //                new PacienteRepository().Salvar(p);
        //            }
        //            else if (TipoOperacao == TipoOperacaoEnum.Excluir)
        //            {
        //                new PacienteRepository().Remover(p);
        //            }

        //            ViewBag.Mensagem = String.Format("Paciente {0} {1} com sucesso.", model.Codigo, (TipoOperacao == TipoOperacaoEnum.Gravar ? "cadastrado" : "excluído"));
        //            Limpar();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Mensagem = "Erro: " + ex.Message + ex.InnerException ?? " - " + ex.InnerException.Message;
        //    }
        //}

        //public ActionResult Limpar()
        //{
        //    return View("Cadastro");
        //}

        //public ActionResult Buscar(Int64 codigo = 0)
        //{
        //    var model = new PacienteModel();
        //    var a = new object();
        //    var entity = new PacienteRepository().ObterPeloCodigo(codigo);
        //    entidadeExiste = entity != null;

        //    if (entidadeExiste)
        //    {
        //        model = new PacienteModel()
        //        {
        //            Codigo = codigo,
        //            Nome = entity.Nome,
        //            DataNascimento = entity.DataNascimento,
        //            CPF = entity.CPF,
        //            Email = entity.Email
        //        };
        //        a = new
        //        {
        //            Codigo = codigo,
        //            Nome = entity.Nome,
        //            DataNascimento = entity.DataNascimento,
        //            CPF = entity.CPF,
        //            Email = entity.Email
        //        };
        //    }

        //    return View(model);
        //}

        //private PacienteRepository db = new PacienteRepository();

        ////
        //// GET: /Paciente/
        //public ActionResult Index()
        //{
        //    return View(db.PacienteModels.ToList());
        //}

        //
        // GET: /Paciente/Detalhar/5
        public ActionResult Detalhar(Int32 codigo = 0)
        {
            //PacienteModel PacienteModel = db.PacienteModels.Find(id);
            //if (PacienteModel == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(PacienteModel);

            var entity = new PacienteRepository().ObterPeloCodigo(codigo);

            if (entity == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(new PacienteModel()
                {
                    Codigo = codigo,
                    Nome = entity.Nome,
                    DataNascimento = entity.DataNascimento,
                    CPF = entity.CPF,
                    Email = entity.Email
                });
            }
        }

        //
        // GET: /Paciente/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        //
        // POST: /Paciente/Cadastrar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(PacienteModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    db.PacienteModels.Add(PacienteModel);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            //return View(PacienteModel);

            if (ModelState.IsValid)
            {
                Paciente p = new Paciente
                {
                    Codigo = model.Codigo,
                    Nome = model.Nome,
                    DataNascimento = model.DataNascimento,
                    CPF = model.CPF,
                    Email = model.Email
                };

                new PacienteRepository().Salvar(p);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        //
        // GET: /Paciente/Editar/5
        public ActionResult Editar(Int32 codigo = 0)
        {
            //PacienteModel PacienteModel = db.PacienteModels.Find(id);
            //if (PacienteModel == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(PacienteModel);

            var entity = new PacienteRepository().ObterPeloCodigo(codigo);

            if (entity == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Cadastrar", new PacienteModel()
                {
                    Codigo = codigo,
                    Nome = entity.Nome,
                    DataNascimento = entity.DataNascimento,
                    CPF = entity.CPF,
                    Email = entity.Email
                });
            }
        }

        //
        // POST: /Paciente/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(PacienteModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(model).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(model);

            if (ModelState.IsValid)
            {
                Paciente p = new Paciente
                {
                    Codigo = model.Codigo,
                    Nome = model.Nome,
                    DataNascimento = model.DataNascimento,
                    CPF = model.CPF,
                    Email = model.Email
                };

                new PacienteRepository().Editar(p);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        //
        // GET: /Paciente/Excluir/5
        public ActionResult Excluir(Int32 codigo = 0)
        {
            //PacienteModel PacienteModel = db.PacienteModels.Find(id);
            //if (PacienteModel == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(PacienteModel);

            var entity = new PacienteRepository().ObterPeloCodigo(codigo);

            if (entity == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(new PacienteModel()
                {
                    Codigo = codigo,
                    Nome = entity.Nome,
                    DataNascimento = entity.DataNascimento,
                    CPF = entity.CPF,
                    Email = entity.Email
                });
            }
        }

        //
        // POST: /Paciente/Excluir/5
        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmed(Int32 codigo)
        {
            //PacienteModel PacienteModel = db.PacienteModels.Find(id);
            //db.PacienteModels.Remove(PacienteModel);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            var repositorio = new PacienteRepository();

            var entity = repositorio.ObterPeloCodigo(codigo);

            if (entity != null)
            {
                repositorio.Remover(entity);
            }

            return RedirectToAction("Index");
        }
    }
}
