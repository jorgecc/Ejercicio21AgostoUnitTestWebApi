using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAgosto21WebApiUnitTest.modelo;
using WebAgosto21WebApiUnitTest.servicio;

namespace TestProject1
{
    class PruebaCliente
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProbarSolicitud()
        {
            // UNIDAD DE PRUEBAS = SOLO FUNCIONES DETERMINISTICA
            // ES DECIR, SOLO FUNCIONES QUE SEGUN UNOS DATOS, DEVUELVE SIEMPRE EL MISMO VALOR.


            // probar con un cliente sin deuda solicitar  un monto dentro de su rango
            Cliente cli=new Cliente { Nombre="john",MontoUtilizado=0,MontoMaximo=1000,Moroso=false};
            Assert.AreEqual(true,ClienteServicio.SolicitudCredito(cli,500));
            // probar con cliente que solicita un numero mayor que el que tiene disponible
            cli = new Cliente { Nombre = "john", MontoUtilizado = 500, MontoMaximo = 1000, Moroso = false };
            Assert.AreEqual(false, ClienteServicio.SolicitudCredito(cli, 600));
            // probar con un cliente ya moroso
            cli = new Cliente { Nombre = "john", MontoUtilizado = 0, MontoMaximo = 1000, Moroso = true };
            Assert.AreEqual(false, ClienteServicio.SolicitudCredito(cli, 600));

            // probar un credito enorme
            cli = new Cliente { Nombre = "john", MontoUtilizado = 500, MontoMaximo = 1000, Moroso = false };
            Assert.AreEqual(false, ClienteServicio.SolicitudCredito(cli, int.MaxValue));
        }

        [Test]
        public void TestAzar()
        {
            var numero= ClienteServicio.Azar();
            Assert.IsTrue(numero>-100 && numero<100,"El valor al azar debe estar entre -100 y 100" );
        }
    }
}
