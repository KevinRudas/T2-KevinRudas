using BibliotecaUPN.Web.DB;
using BibliotecaUPN.Web.IServicios;
using BibliotecaUPN.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BibliotecaUPN.Web.Controllers
{
    public class AuthController : Controller
    {
        private ISession session;
        public AuthController (ISession session)
        {
            this.session = session;
        }
        [HttpGet]
        public ActionResult Login()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            //var app = new AppContext();
           var usuario= session.LogueoUsuario(username,password);
           // var usuario = app.Usuarios.Where(o => o.Username == username && o.Password == password).FirstOrDefault();
            if (usuario != null)
            {
                FormsAuthentication.SetAuthCookie(username, false);
               
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Validation = "Usuario y/o contraseña incorrecta";
            return View();
        }


        public ActionResult Logout() {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}