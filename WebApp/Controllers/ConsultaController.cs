using DAL.Model;
using DAL.Repository;
using DAL.Util;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ConsultaController : Controller
    {
        public ActionResult Index()
        {
            var lista = new List<ConsultaModel>();
            foreach (var consulta in new ConsultaRepository().ListarTodos())
            {
                lista.Add(MapearEntidadeEmModelo(consulta));
            }
            return View(lista);
        }

        // GET: /Consulta/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: /Consulta/Cadastrar
        [HttpPost]
        public ActionResult Cadastrar(ConsultaModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //RepositorioContainer repositorio = new RepositorioContainer();
                    
                    var profissional = new ProfissionalRepository().Obter(model.ProfissionalId);
                    if (profissional == null)
                    {
                        ModelState.AddModelError("Inexistência", String.Format(Mensagem.RegistroNaoEncontrado, "Profissional", model.ProfissionalId));
                    }

                    var paciente = new PacienteRepository().Obter(model.PacienteId);
                    if (paciente == null)
                    {
                        ModelState.AddModelError("Inexistência", String.Format(Mensagem.RegistroNaoEncontrado, "Paciente", model.PacienteId));
                    }

                    if (ModelState.IsValid)
                    {
                        var consultaRepository = new ConsultaRepository();
                        Consulta consulta = consultaRepository.Obter(model.Id);
                        TipoOperacaoEnum tipoDeOperacao;

                        if (consulta == null)
                        {
                            consulta = new Consulta
                            {
                                Id = model.Id,
                                Paciente = paciente,
                                PacienteId = paciente.Id,
                                Profissional = profissional,
                                ProfissionalId = profissional.Id,
                                DataHora = Convert.ToDateTime(model.DataHora),
                                Status = model.Status
                            };

                            tipoDeOperacao = TipoOperacaoEnum.Insercao;
                        }
                        else
                        {
                            consulta.Paciente = paciente;
                            consulta.PacienteId = paciente.Id;
                            consulta.Profissional = profissional;
                            consulta.ProfissionalId = profissional.Id;
                            consulta.DataHora = Convert.ToDateTime(model.DataHora);
                            consulta.Status = model.Status;

                            tipoDeOperacao = TipoOperacaoEnum.Alteracao;
                        }

                        consultaRepository.Inserir(consulta);
                        consultaRepository.Salvar();

                        ViewBag.Mensagem = String.Format((tipoDeOperacao == TipoOperacaoEnum.Insercao ? Mensagem.Inclusao : Mensagem.Alteracao), consulta.Id);
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Mensagem = ex.Message;
                }
            }

            return View(model);
        }

        // GET: /Consulta/Detalhar/5
        public ActionResult Detalhar(Int32 id = 0)
        {
            return ObterEntidadeModelo(id);
        }

        // GET: /Consulta/Editar/5
        public ActionResult Editar(Int32 id = 0)
        {
            return ObterEntidadeModelo(id);
        }

        // GET: /Consulta/Excluir/5
        public ActionResult Excluir(Int32 id = 0)
        {
            var consulta = new ConsultaRepository().Obter(id);

            if (consulta == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(MapearEntidadeEmModelo(consulta));
            }
        }

        // POST: /Consulta/Excluir/5
        [HttpPost, ActionName("Excluir")]
        public ActionResult ExclusaoConfirmada(Int32 id)
        {
            try
            {
                var repositorio = new ConsultaRepository();

                var consulta = repositorio.Obter(id);
                if (consulta != null)
                {
                    repositorio.Excluir(consulta);
                    repositorio.Salvar();
                    Session.Add("Mensagem", String.Format(Mensagem.Remocao, consulta.Id));
                }
                else
                    Session.Add("Mensagem", String.Format(Mensagem.RegistroNaoEncontrado, "Consulta", consulta.Id));
            }
            catch (Exception ex)
            {
                Session.Add("Mensagem", ex.Message);
            }

            return RedirectToAction("Index");
        }

        private ActionResult ObterEntidadeModelo(Int32 id)
        {
            var consulta = new ConsultaRepository().Obter(id);

            if (consulta == null)
            {
                return HttpNotFound();
            }
            else
            {
                Session.Add("TipoDeOperacao", TipoOperacaoEnum.Alteracao);

                return View("Cadastrar", MapearEntidadeEmModelo(consulta));
            }
        }

        private ConsultaModel MapearEntidadeEmModelo(Consulta consulta)
        {
            return new ConsultaModel()
            {
                Id = consulta.Id,
                PacienteId = consulta.Paciente != null ? consulta.Paciente.Id : default(Int32),
                PacienteNome = consulta.Paciente != null ? consulta.Paciente.Nome : String.Empty,
                ProfissionalId = consulta.Profissional != null ? consulta.Profissional.Id : default(Int32),
                ProfissionalNome = consulta.Profissional != null ? consulta.Profissional.Nome : String.Empty,
                DataHora = consulta.DataHora != null ? ((DateTime)consulta.DataHora).ToString("yyy-MM-dd") : String.Empty,
                Status = consulta.Status != null ? (StatusConsultaEnum)consulta.Status : (StatusConsultaEnum)0,
            };
        }
    }
}
