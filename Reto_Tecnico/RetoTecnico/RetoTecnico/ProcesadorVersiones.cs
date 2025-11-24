namespace Versiones
{
    public class ProcesadorVersiones
    {
        // Procesa la cadena y devuelve la version y resultado de la validacion.
        public string Procesar(string cadena)
        {
            Dictionary<string, string> campos = ParsearCadena(cadena);

            string version = CalcularVersion(campos);

            bool esValido = Validar(campos);

            string resultado = esValido ? "Success" : "Error";

            return $"Version {version}|{resultado}";
        }

        // Convierte la cadena a un diccionario clave-valor
        private Dictionary<string, string> ParsearCadena(string cadena)
        {
            Dictionary<string, string> campos = new Dictionary<string, string>();

            if (string.IsNullOrWhiteSpace(cadena))
            {
                return campos;
            }

            string[] partes = cadena.Split('|');

            foreach (string parte in partes)
            {
                string[] partesClaveValor = parte.Split(":", 2);
                if (partesClaveValor.Length != 2)
                    continue;

                string clave = partesClaveValor[0].Trim();
                string valor = partesClaveValor[1].Trim();

                if (!string.IsNullOrEmpty(clave))
                    campos[clave] = valor;
            }
            return campos;
        }

        // Valida que los campos cumplan lo requerido
        private bool Validar(Dictionary<string, string> campos)
        {
            // name: requerido, min 5 caracteres
            if (!campos.ContainsKey("name") || campos["name"].Length < 5)
                return false;

            // age: requerido, número >= 18
            if (!campos.ContainsKey("age"))
                return false;

            if (!int.TryParse(campos["age"], out int edad))
                return false;

            if (edad < 18)
                return false;

            // state: requerido, min 5 caracteres
            if (!campos.ContainsKey("state") || campos["state"].Length < 5)
                return false;

            // zipcode: opcional pero si viene debe ser 5 digitos
            if (campos.ContainsKey("zipcode"))
            {
                string zip = campos["zipcode"];

                if (zip.Length != 5)
                    return false;

                foreach (char c in zip)
                {
                    if (!char.IsDigit(c))
                        return false;
                }
            }

            // valida el campo status
            if (campos.ContainsKey("status"))
            {
                string status = campos["status"].ToLower();

                if (status != "soltero" && status != "casado")
                    return false;
            }
            return true;
        }

        //Calcula la version segun tenga zipcode o estatus
        private string CalcularVersion(Dictionary<string, string> campos)
        {
            if (campos.ContainsKey("zipcode") || campos.ContainsKey("status"))
                return "4.0";

            return "3.3";
        }
    }
}
