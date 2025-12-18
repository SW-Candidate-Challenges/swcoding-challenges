using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class RetoSumasw
{
    // Se usa object y forzamos a checar el tipo.
    public static string SumarNumeros(object A_input, object B_input)
    {
        int Num_A;
        int Num_B;

        //Si son texto, decimal(float / double) o booleano(true / false), ¡error!
        // Se detiene lo que podría sumar mal
        if (A_input is string || B_input is string ||
            A_input is float || B_input is float ||
            A_input is double || B_input is double ||
            A_input is bool || B_input is bool)
        {
            return "Ambos parámetros deben ser números enteros.";
        }

        // Si son nulos, eror.
        if (A_input == null || B_input == null)
        {
            return "Ambos parámetros deben ser números enteros.";
        }

        // Aquí solo quedan enteros y tipos raros (Arrays/Objects).
        try
        {
            // fallra si es un Array o object
            Num_A = Convert.ToInt32(A_input);
            Num_B = Convert.ToInt32(B_input);

            // Si llega aqu,exito.
            int ResultadoFinal = Num_A + Num_B;

            return $"El resultado de la suma es: {ResultadoFinal} SW";
        }
        catch (Exception) // Capturamos el error.
        {
            return "Ambos parámetros deben ser números enteros.";
        }
    }
}

