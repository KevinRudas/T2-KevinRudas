using BibliotecaUPN.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUPN.Web.IServicios
{
    public interface IAppContext
    {
        IDbSet<Biblioteca> Bibliotecas{ get; set; }
        IDbSet<Usuario> Usuarios { get; set; }
        int SaveChanges();
    }
}
