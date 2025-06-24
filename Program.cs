// Solucion al reto Versiones por Luis Rodriguez.
// Objetivo: Procesar una cadena de datos y determinar la validez de la informacion

// name: Debe estar presente y tener al menos 5 caracteres.
// age: Debe ser un número mayor o igual a 18.
// state: Debe estar presente y tener al menos 5 caracteres.
// zipcode: Debe ser un código postal válido de 5 dígitos.
// status: Solo acepta los valores soltero o casado (sin importar mayúsculas o minúsculas).
// La función debe devolver un string con el formato Version {version}|{resultado}, donde:
// version será 4.0 si se encuentra zipcode o status, o 3.3 si estos no están presentes.
// resultado será Success si todos los valores son válidos, de lo contrario, Error.

using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Listado de pruebas para validar la funcion (Entrada | Esperado).
        var pruebas = new List<(string entrada, string esperado)>
        {
            ("name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero", "Version 4.0|Success"),
            ("name:PedroL|age:22|state:Nayarit","Version 3.3|Success"),
            ("name:Ana|age:19|state:Yucatán|zipcode:1234|status:Casado", "Version 4.0|Error"),
            ("name:Roberto|age:17|state:Sonora|status:Soltero", "Version 4.0|Error"),
            ("name:Elisa|age:30|state:DF|zipcode:99999|status:divorciado", "Version 4.0|Error")
        };

        // Ejecutamos cada una de las pruebas e imprimimos en Consola su resultado.
        foreach (var prueba in pruebas)
        {
            // Obtenemos el resultado pasandole la Entrada a la funcion que valida.
            string resultado = ValidarCadena(prueba.entrada);
            // Validamos si el resultado era lo esperado o esta incorrecto.
            string estado = resultado == prueba.esperado ? "Ok" : $"Error (esperado: {prueba.esperado})";

            // Imprimir en Consola los resultados.
            Console.WriteLine($"Entrada: {prueba.entrada}");
            Console.WriteLine($"Resultado: {resultado} -> {estado}\n");
        }
    }

    // Funcion que valida la cadena de informacion.
    static string ValidarCadena(string value)
    {
        // Primeramente separar cada uno de los valores de la cadena para su revision individual.
        string[] valores = value.Split('|');

        // Convertir a diccionario para facilitar el acceso en formato (clave - valor).
        var diccionario = valores
            .Select(par => par.Split(':')) // Recorre los elementos y los separa en dos partes
            .Where(par => par.Length == 2) // Filtramos solo los elementos que contengan exactamente 2 elementos (Clave - Valor).
            .ToDictionary(par => par[0].ToLower(), par => par[1]); // Convertimos el resultado en diccionario.

        // Determinar la version a la que corresponde la cadena.
        bool tieneZipcode = diccionario.ContainsKey("zipcode"); // Valida si contiene Zipcode.
        bool tieneStatus = diccionario.ContainsKey("status"); // Valida si contiene Status.
        string version = (tieneZipcode || tieneStatus) ? "4.0" : "3.3"; // Diferenciar entre versiones.

        // Empezar a validar el resto de los campos.
        // name: Debe estar presente y tener al menos 5 caracteres.
        if (!diccionario.ContainsKey("name") || diccionario["name"].Length < 5)
            return $"Version {version}|Error"; // Si name es menor a 5 o no existe devolver error.

        // age: Debe ser un número mayor o igual a 18.
        if (!diccionario.ContainsKey("age") || !int.TryParse(diccionario["age"], out int edad) || edad < 18)
            return $"Version {version}|Error"; // Si el valor no existe, no es numero o es menor a 18 devolver error.

        // state: Debe estar presente y tener al menos 5 caracteres.
        if (!diccionario.ContainsKey("state") || diccionario["state"].Length < 5)
            return $"Version {version}|Error"; // Si no esta presente o es menor a 5 caracteres devolver error.

        // zipcode: Debe ser un código postal válido de 5 dígitos.
        if (tieneZipcode && !Regex.IsMatch(diccionario["zipcode"], @"^\d{5}$"))
            return $"Version {version}|Error"; // Uso de expresion regular para validar que tenga exactamente 5 digitos numeros, de lo contrario devuelve error.

        // status: Solo acepta los valores soltero o casado (sin importar mayúsculas o minúsculas).
        if (tieneStatus)
        {
            string status = diccionario["status"].ToLower(); // Convertimos a minusculas para facilitar comparacion
            if (status != "soltero" && status != "casado") // Validamos si es diferente a soltero o casado devolvemos error.
                return $"Version {version}|Error";
        }

        // Validaciones terminadas
        return $"Version {version}|Success";
    }
}