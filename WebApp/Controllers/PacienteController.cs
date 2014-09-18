using Domain.Entity;
using Domain.Enum;
using Domain.Repository;
using System;
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
        public ActionResult Cadastrar(PacienteModel model, String command)
        {
            CarregarTipoOperacao(command);

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
                        Nome = model.Nome,
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

                    ViewBag.Mensagem = String.Format("Paciente {0} {1} com sucesso.", model.Codigo, (TipoOperacao == TipoOperacaoEnum.Gravar ? "cadastrado" : "excluído"));
                    Limpar();
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

        private PacienteModel Buscar(Int64 codigo)
        {
            var model = new PacienteModel();
            var entity = new PacienteRepository().ObterPeloCodigo(codigo);

            if (entity != null)
            {
                entidadeExiste = true;
                model = new PacienteModel()
                {
                    Codigo = codigo,
                    Nome = entity.Nome,
                    DataNascimento = entity.DataNascimento,
                    CPF = entity.CPF,
                    Email = entity.Email
                };
            }
            return model;
        }
    }
}
