using BibliotecaUPN.Web.Constantes;
using BibliotecaUPN.Web.DB;
using BibliotecaUPN.Web.IServicios;
using BibliotecaUPN.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaUPN.Web.Servicios
{
    public class BilbiotecaServicios : IBiblioteca
    {
         AppContext cont = new AppContext();
        

        public void addBilioteca(int libro,Usuario user)
        {
            var app = new AppContext();
           
            
            // TO-DO validar si ya existe el libro en la biblioteca, en ese caso no guardar y notificar

            var biblioteca = new Biblioteca
            {
                LibroId = libro,
                UsuarioId = user.Id,
                Estado = ESTADO.POR_LEER
            };
            cont.Bibliotecas.Add(biblioteca);
            cont.SaveChanges();
        }

        public List<Biblioteca> istaIndex()
        {
            throw new NotImplementedException();
        }
    }
}