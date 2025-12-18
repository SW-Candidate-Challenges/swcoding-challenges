using Versiones;

namespace VersionesTest
{
    [TestClass]
    public  class ProcesadorVersionesTest
    {
        [TestMethod]
        public void Cadena_Completa()
        {
            var servicio = new ProcesadorVersiones();

            string cadena = "name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero";

            string resultado = servicio.Procesar(cadena);

            Assert.AreEqual("Version 4.0|Success", resultado);
        }

        [TestMethod]
        public void Cadena_SinZipNiStatus()
        {
            var servicio = new ProcesadorVersiones();

            string cadena = "name:PedroL|age:22|state:Nayarit";

            string resultado = servicio.Procesar(cadena);

            Assert.AreEqual("Version 3.3|Success", resultado);
        }

        [TestMethod]
        public void Cadena_NameYZipIncorrectos()
        {
            var servicio = new ProcesadorVersiones();

            string cadena = cadena = "name:Ana|age:19|state:Yucatán|zipcode:1234|status:Casado";

            string resultado = servicio.Procesar(cadena);

            Assert.AreEqual("Version 4.0|Error", resultado);
        }

        [TestMethod]
        public void Cadena_MenorEdad()
        {
            var servicio = new ProcesadorVersiones();

            string cadena = "name:Roberto|age:17|state:Sonora|status:Soltero";

            string resultado = servicio.Procesar(cadena);

            Assert.AreEqual("Version 4.0|Error", resultado);
        }

        [TestMethod]
        public void StateYStatusInvaliido()
        {
            var servicio = new ProcesadorVersiones();

            string cadena = "name:Elisa|age:30|state:DF|zipcode:99999|status:divorciado";

            string resultado = servicio.Procesar(cadena);

            Assert.AreEqual("Version 4.0|Error", resultado);
        }

        [TestMethod]
        public void Cadena_vacia()
        {
            var servicio = new ProcesadorVersiones();

            string cadena = "";

            string resultado = servicio.Procesar(cadena);

            Assert.AreEqual("Version 3.3|Error", resultado);
        }
    }
}


