using Domain.Entity;
using Domain.Enum;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PacienteController : Controller
    {
        private TipoOperacaoEnum TipoOperacao;
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarPaciente(PacienteModel model, String command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Paciente p = new Paciente {
                        Codigo = 0,
                        Descricao = model.Descricao,
                        DataNascimento = model.DataNascimento
                    };

                    TipoOperacao = command == TipoOperacaoEnum.Gravar.ToString() ? TipoOperacaoEnum.Gravar : TipoOperacaoEnum.Excluir;

                    ProcessarOperacao(p, TipoOperacao);

                    ViewBag.Mensagem = "Paciente " + (TipoOperacao == TipoOperacaoEnum.Gravar ? "cadastrado" : "excluído") + " com sucesso";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Mensagem = "Erro: " + ex.Message + " - " + ex.InnerException ?? ex.InnerException.Message;
            }

            return View("Cadastro");
        }

        private void ProcessarOperacao(Paciente p, TipoOperacaoEnum TipoOperacao)
        {
            var repository = new PacienteRepository();

            if (TipoOperacao == TipoOperacaoEnum.Gravar)
            {
                repository.Salvar(p);
            }
            else if (TipoOperacao == TipoOperacaoEnum.Excluir)
            {
                repository.Remover(p);
            }
        }
    }
}
