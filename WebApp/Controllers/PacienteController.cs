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
        private Boolean entidadeExiste;

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarPaciente(PacienteModel model, String command)
        {
            CarregarTipoOperacao(command);

            var entity = new Paciente();

            if (TipoOperacao == TipoOperacaoEnum.Buscar)
            {
                model = Buscar(model.Codigo);
            }
            else if (TipoOperacao == TipoOperacaoEnum.Gravar)
            {
                ProcessarOperacao(model, TipoOperacao);
            }
            else if (TipoOperacao == TipoOperacaoEnum.Excluir)
            {
                ProcessarOperacao(model, TipoOperacao);
            }

            return View("Cadastro", model);
        }

        private void CarregarTipoOperacao(String command)
        {
                 if (command == TipoOperacaoEnum.Buscar.ToString())  { TipoOperacao = TipoOperacaoEnum.Buscar; }
            else if (command == TipoOperacaoEnum.Gravar.ToString())  { TipoOperacao = TipoOperacaoEnum.Gravar; }
            else if (command == TipoOperacaoEnum.Excluir.ToString()) { TipoOperacao = TipoOperacaoEnum.Excluir; }
        }

        private void ProcessarOperacao(PacienteModel model, TipoOperacaoEnum TipoOperacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Paciente p = new Paciente
                    {
                        Codigo = entidadeExiste ? 0 : model.Codigo,
                        Descricao = model.Descricao,
                        DataNascimento = model.DataNascimento
                    };

                    if (TipoOperacao == TipoOperacaoEnum.Gravar)
                    {
                        new PacienteRepository().Salvar(p);
                    }
                    else if (TipoOperacao == TipoOperacaoEnum.Excluir)
                    {
                        new PacienteRepository().Remover(p);
                    }

                    ViewBag.Mensagem = "Paciente " + (TipoOperacao == TipoOperacaoEnum.Gravar ? "cadastrado" : "excluído") + " com sucesso";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Mensagem = "Erro: " + ex.Message + ex.InnerException ?? " - " + ex.InnerException.Message;
            }
        }

        public ActionResult Limpar()
        {
            return View("Cadastro");
        }

        private PacienteModel Buscar(Int32 codigo)
        {
            var entity = new PacienteRepository().ObterPeloCodigo(codigo);
            entidadeExiste = entity != null;
            var model = new PacienteModel()
            {
                Codigo = codigo,
                Descricao = entity.Descricao,
                DataNascimento = entity.DataNascimento
            };
            return model;
        }
    }
}
