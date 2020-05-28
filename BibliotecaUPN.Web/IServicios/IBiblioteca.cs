using BibliotecaUPN.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUPN.Web.IServicios
{
    public interface IBiblioteca
    {
        List<Biblioteca> istaIndex();
        void addBilioteca(int libro, Usuario user);

    }
}
