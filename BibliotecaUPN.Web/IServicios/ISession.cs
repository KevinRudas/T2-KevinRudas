using BibliotecaUPN.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUPN.Web.IServicios
{
    public interface ISession
    {
        Usuario LogueoUsuario(string username ,  string password);
    }
}
