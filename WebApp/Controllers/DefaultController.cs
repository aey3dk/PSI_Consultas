using Domain.Repository;
using System;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult RecriarBaseDados()
        {
            try
            {
                new BaseRepository().RecriarBaseDados();
                ViewBag.Mensagem = "Base de dados recriada com sucesso";
            }
            catch (Exception ex)
            {
                ViewBag.Mensagem = "Erro ao recriar base de dados: " + ex.Message;
            }

            return View("Index");
        }

        public ActionResult PopularBaseDados()
        {
            try
            {
                new BaseRepository().PopularBaseDados();
                ViewBag.Mensagem = "Base de dados populado com sucesso";
            }
            catch (Exception ex)
            {
                ViewBag.Mensagem = "Erro ao popular base de dados: " + ex.Message;
            }

            return View("Index");
        }
    }
}
