using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace pruebas.pruebasTs
{
    [TestFixture]
    public class Selenium
    {
        [Test]
        public void Provarlogin()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Auth/Login";

            var txtUsusario = chromeDriver.FindElementById("idUsuario");
            txtUsusario.SendKeys("admin");

            var txtPassword = chromeDriver.FindElementById("idPassword");
            txtPassword.SendKeys("admin");

            Thread.Sleep(TimeSpan.FromSeconds(2));

            var btnEntrar = chromeDriver.FindElementById("btnEntrar");
            btnEntrar.Click();

            var btnAgregar = chromeDriver.FindElementById("btnAgregar");
            
            Assert.IsNotNull(btnAgregar);
        }

        [Test]
        public void AgregarBiblioteca()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Auth/Login";

            var txtUsusario = chromeDriver.FindElementById("idUsuario");
            txtUsusario.SendKeys("admin");

            var txtPassword = chromeDriver.FindElementById("idPassword");
            txtPassword.SendKeys("admin");

            Thread.Sleep(TimeSpan.FromSeconds(2));

            var btnEntrar = chromeDriver.FindElementById("btnEntrar");
            btnEntrar.Click();

            var btnAgregarBiblioteca = chromeDriver.FindElementById("temaLink");
            btnAgregarBiblioteca.Click();

            var probarBiblioteca = chromeDriver.FindElementById("miBiblioteca");

            Assert.IsNotNull(probarBiblioteca);
        }

        [Test]
        public void ProbarLeyendo()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Auth/Login";

            var txtUsusario = chromeDriver.FindElementById("idUsuario");
            txtUsusario.SendKeys("admin");

            var txtPassword = chromeDriver.FindElementById("idPassword");
            txtPassword.SendKeys("admin");

            Thread.Sleep(TimeSpan.FromSeconds(2));

            var btnEntrar = chromeDriver.FindElementById("btnEntrar");
            btnEntrar.Click();

            var btnAgregarBiblioteca = chromeDriver.FindElementById("temaLink");
            btnAgregarBiblioteca.Click();

            var btnLeyendo = chromeDriver.FindElementById("btnLeyendo");
            btnLeyendo.Click();

            var probarBiblioteca = chromeDriver.FindElementById("miBiblioteca");

            Assert.IsNotNull(probarBiblioteca);
        }

        [Test]
        public void ProbaTerminado()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Auth/Login";

            var txtUsusario = chromeDriver.FindElementById("idUsuario");
            txtUsusario.SendKeys("admin");

            var txtPassword = chromeDriver.FindElementById("idPassword");
            txtPassword.SendKeys("admin");

            Thread.Sleep(TimeSpan.FromSeconds(2));

            var btnEntrar = chromeDriver.FindElementById("btnEntrar");
            btnEntrar.Click();

            var btnAgregarBiblioteca = chromeDriver.FindElementById("temaLink");
            btnAgregarBiblioteca.Click();

            var btnTerminado = chromeDriver.FindElementById("btnTerminado");
            btnTerminado.Click();

            var probarBiblioteca = chromeDriver.FindElementById("miBiblioteca");

            Assert.IsNotNull(probarBiblioteca);
        }
    }
}
