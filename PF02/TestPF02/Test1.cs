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

        [TestMethod]
        public void EsContrasenyaValida_Null_DevuelveFalse()
        {
            bool resultado = _funciones.EsContrasenyaValida(null);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_Vacia_DevuelveFalse()
        {
            bool resultado = _funciones.EsContrasenyaValida("");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_MenosDeOchoCaracteres_DevuelveFalse()
        {
            bool resultado = _funciones.EsContrasenyaValida("abc#");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_SinAlmohadilla_DevuelveFalse()
        {
            Assert.IsFalse(_funciones.EsContrasenyaValida("abcdefgh"));
            Assert.IsFalse(_funciones.EsContrasenyaValida("abcdefghijkl"));
        }

        [TestMethod]
        public void EsContrasenyaValida_OchoCaracteresConAlmohadilla_DevuelveTrue()
        {
            bool resultado = _funciones.EsContrasenyaValida("abcdefg#");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_MasDeOchoCaracteresConAlmohadilla_DevuelveTrue()
        {
            bool resultado = _funciones.EsContrasenyaValida("Clave#Segura123");
            Assert.IsTrue(resultado);
        }
    }
}