using Domain.Entity;
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

        //
        // GET: /Paciente/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        //
        // POST: /Paciente/Cadastrar
        [HttpPost]
        //[ValidateAntiForgeryToken]
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
                    DataNascimento = Convert.ToDateTime(model.DataNascimento),
                    CPF = model.CPF,
                    Email = model.Email
                };

                new PacienteRepository().Salvar(p);

                return RedirectToAction("Index");
            }

            return View(model);
        }

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
                var A = new PacienteModel()
                {
                    Codigo = codigo,
                    Nome = entity.Nome,
                    DataNascimento = entity.DataNascimento.ToString("yyy-MM-dd"),
                    CPF = entity.CPF,
                    Email = entity.Email
                };
                return View(A);
            }
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
                    DataNascimento = entity.DataNascimento.ToString("yyy-MM-dd"),
                    CPF = entity.CPF,
                    Email = entity.Email
                });
            }
        }

        //
        // POST: /Paciente/Editar/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
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
                    DataNascimento = Convert.ToDateTime(model.DataNascimento),
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
                    DataNascimento = entity.DataNascimento.ToString("yyy-MM-dd"),
                    CPF = entity.CPF,
                    Email = entity.Email
                });
            }
        }

        //
        // POST: /Paciente/Excluir/5
        [HttpPost, ActionName("Excluir")]
        //[ValidateAntiForgeryToken]
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
