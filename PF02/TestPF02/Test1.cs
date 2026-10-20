using PF02;

namespace TestPF02
{
    [TestClass]
    public sealed class Test1
    {
        private Funciones _funciones;

        [TestInitialize]
        public void Setup()
        {
            _funciones = new Funciones();
        }

        [TestMethod]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno()
        {
            long resultado = _funciones.CalcularFactorial(-5);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            long resultado = _funciones.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_NumeroPositivo_DevuelveFactorialCorrecto()
        {
            Assert.AreEqual(1, _funciones.CalcularFactorial(1));
            Assert.AreEqual(24, _funciones.CalcularFactorial(4));
            Assert.AreEqual(120, _funciones.CalcularFactorial(5));
        }
    }
}