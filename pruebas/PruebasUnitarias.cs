using BibliotecaUPN.Web.IServicios;
using BibliotecaUPN.Web.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using BibliotecaUPN.Web.Controllers;
using System.Web.Mvc;

namespace pruebas
{
    [TestFixture]
    public class PruebasUnitarias
    {
        [Test]
        public void LogeuoUsuario()
        {
            string username = "admin";
            string password = "admin";
            var mocksession = new Mock<ISession>();
            mocksession.Setup(o => o.LogueoUsuario(username, password));
            var controler = new AuthController(mocksession.Object);
            var view = controler.Login(username, password) as ViewResult;
            Assert.IsInstanceOf<ViewResult>(view);
            mocksession.Verify(o => o.LogueoUsuario(username, password), Times.Once);
        }
    }
}
