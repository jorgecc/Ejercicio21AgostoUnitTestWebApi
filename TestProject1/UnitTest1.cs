using NUnit.Framework;
using WebAgosto21WebApiUnitTest.servicio;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumar()
        {
            // probando?
            // 1) casos obvios.
            Assert.AreEqual(4, CalculadoraServicio.Sumar(2,2) );
            // 2) casos limites.
            Assert.AreEqual(0, CalculadoraServicio.Sumar(0, 0) );
            // 3) forzar a que se caiga (o no de el resultado esperado
            Assert.AreEqual(0, CalculadoraServicio.Sumar(int.MaxValue, 2));
            Assert.AreEqual(0, CalculadoraServicio.Sumar(int.MinValue, -2));



            // Assert.Pass();
        }

        [Test]
        public void TestRestar()
        {
            Assert.AreEqual(0, CalculadoraServicio.Restar(2, 2));
            Assert.AreEqual(0, CalculadoraServicio.Restar(0, 0));
            Assert.AreEqual(0, CalculadoraServicio.Restar(int.MinValue, 2));
            Assert.AreEqual(0, CalculadoraServicio.Restar(int.MaxValue, -2));
        }
        [Test]
        public void TestMultiplicar()
        {
            Assert.AreEqual(4, CalculadoraServicio.Multiplicar(2, 2));
            Assert.AreEqual(0, CalculadoraServicio.Multiplicar(0, 0));
            Assert.AreEqual(0, CalculadoraServicio.Multiplicar(int.MinValue, 2));
            Assert.AreEqual(0, CalculadoraServicio.Multiplicar(int.MaxValue, 2));
            Assert.AreEqual(0, CalculadoraServicio.Multiplicar(int.MaxValue, int.MaxValue));
        }
        [Test]
        public void TestDividir()
        {
            Assert.AreEqual(1, CalculadoraServicio.Dividir(2, 2));
            Assert.AreEqual(1, CalculadoraServicio.Dividir(4, 3));
            Assert.AreEqual(0, CalculadoraServicio.Dividir(0, 0));
            Assert.AreEqual(-1073741824, CalculadoraServicio.Dividir(int.MinValue, 2));
            Assert.AreEqual(1073741823, CalculadoraServicio.Dividir(int.MaxValue, 2));
            Assert.AreEqual(0, CalculadoraServicio.Dividir(1, int.MaxValue));
        }
    }
}