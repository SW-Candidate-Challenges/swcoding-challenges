namespace SumaSW.Test
{
    [TestClass]
    public class ProcesadorSumaTest
    {
        [TestMethod]
        public void SumarNumeros_AmbosEnteros()
        {
            var servicio = new ProcesadorSuma();

            string resultado = servicio.SumarNumeros(5, 3, out string motivo);

            Assert.AreEqual($"El resultado de la suma es: 8 SW", resultado);
            Assert.AreEqual(string.Empty, motivo);
        }

        [TestMethod]
        public void SumarNumeros_AEsDecimal()
        {
            var servicio = new ProcesadorSuma();

            string resultado = servicio.SumarNumeros(5.5, 2, out string motivo);

            Assert.AreEqual("Ambos parámetros deben ser números enteros.", resultado);
            Assert.AreEqual("a es un número decimal", motivo);
        }

        [TestMethod]
        public void SumarNumeros_AEsString()
        {
            var servicio = new ProcesadorSuma();

            string resultado = servicio.SumarNumeros("10", 5, out string motivo);

            Assert.AreEqual("Ambos parámetros deben ser números enteros.", resultado);
            Assert.AreEqual("a es string", motivo);
        }

        [TestMethod]
        public void SumarNumeros_BEsNull()
        {
            var servicio = new ProcesadorSuma();

            string resultado = servicio.SumarNumeros(8, null, out string motivo);

            Assert.AreEqual("Ambos parámetros deben ser números enteros.", resultado);
            Assert.AreEqual("b no es un número", motivo);
        }

        [TestMethod]
        public void SumarNumeros_AEsBooleano()
        {
            var servicio = new ProcesadorSuma();

            string resultado = servicio.SumarNumeros(true, 3, out string motivo);

            Assert.AreEqual("Ambos parámetros deben ser números enteros.", resultado);
            Assert.AreEqual("a es booleano", motivo);
        }

        [TestMethod]
        public void SumarNumeros_AmbosIncorrectos()
        {
            var servicio = new ProcesadorSuma();

            string resultado = servicio.SumarNumeros(new int[] { }, new object(), out string motivo);

            Assert.AreEqual("Ambos parámetros deben ser números enteros.", resultado);
            Assert.AreEqual("Ambos son tipos incorrectos", motivo);
        }
    }
}
