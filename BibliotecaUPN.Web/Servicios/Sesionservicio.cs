using BibliotecaUPN.Web.DB;
using BibliotecaUPN.Web.IServicios;
using BibliotecaUPN.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace BibliotecaUPN.Web.Servicios
{
    public class Sesionservicio : ISession
    {
        HttpSessionState session;
             

        public Usuario LogueoUsuario(string username, string password)
        {
            AppContext cont = new AppContext();
            session = HttpContext.Current.Session;
            Usuario usuario = cont.Usuarios.Where(o => o.Username == username && o.Password == password).FirstOrDefault();

            session["Usuario"] = usuario.Id.ToString();
            return usuario;
        }
    }
}
