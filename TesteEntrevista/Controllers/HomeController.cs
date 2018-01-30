using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadFuncionario.Models;

namespace CadFuncionario.Controllers
{
    public class HomeController : Controller
    {
        private FuncionarioContext db = new FuncionarioContext();
        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult TelaLogin()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TelaLogin(Usuario u)
        {
            // esta action trata o post (login)
            if (ModelState.IsValid) //verifica se é válido
            {
                using (FuncionarioContext dc = new FuncionarioContext())
                {
                    var v = dc.Usuario.Where(a => a.USER_NAME.Equals(u.USER_NAME) && a.USER_SENHA.Equals(u.USER_SENHA)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["usuarioLogadoID"] = v.UsuarioID.ToString();
                        Session["nomeUsuarioLogado"] = v.USER_NAME.ToString();
                        return RedirectToAction("Index","Funcionarios");
                    }
                }
            }
            return View(u);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}