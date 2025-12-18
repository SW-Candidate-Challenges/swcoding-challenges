namespace SumaSW
{
    public class ProcesadorSuma
    {
        public string SumarNumeros(object a, object b, out string motivo)
        {
            motivo = string.Empty;

            //Caso Valido
            if (a is int num1 && b is int num2)
            {
                int suma = num1 + num2;
                return $"El resultado de la suma es: {suma} SW";
            }

            //Casos invalidos
            //a = 5.5, b = 2
            if (a is double)
            {
                motivo = "a es un número decimal";
            }
            else if (b is double)
            {
                motivo = "b es un número decimal";
            }
            // a = "10", b = 5
            else if (a is string)
            {
                motivo = "a es string";
            }
            else if (b is string)
            {
                motivo = "b es string";
            }
            // a = 8, b = null;
            else if (b is null)
            {
                motivo = "b no es un número";
            }
            else if (a is null)
            {
                motivo = "a no es un número";
            }
            // a = true, b = 3
            else if (a is bool)
            {
                motivo = "a es booleano";
            }
            else if (b is bool)
            {
                motivo = "b es booleano";
            }
            // a = [], b = {}
            else if (a is not int && b is not int)
            {
                motivo = "Ambos son tipos incorrectos";
            }

            return "Ambos parámetros deben ser números enteros.";
        }
    }
}