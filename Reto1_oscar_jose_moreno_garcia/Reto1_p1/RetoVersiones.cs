using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions; // Necesaria para el check del ZipCode.

public static class RetoVersiones
{
    // Constantes.
    private const string RESULTADO_EXITO = "Success";
    private const string RESULTADO_ERROR = "Error";
    private const string VERSION_4_0 = "4.0";
    private const string VERSION_3_3 = "3.3";

    // Revisa los datos y decide la versión y el resultado.

    public static string ProcesarDatos(string data)
    {
        bool esValidoTotal = true;
        bool usaVersion40 = false;

        Dictionary<string, string> dataMap;


        try
        {
            // Convierto la cadena a un Diccionario.
            dataMap = data.Split('|')
                        .Where(s => s.Contains(':'))
                        .Select(s => s.Split(':'))
                        .ToDictionary(p => p[0].Trim().ToLower(), p => p[1].Trim());
        }
        catch
        {
            // Error si el formato viene roto.
            esValidoTotal = false;
            dataMap = new Dictionary<string, string>();
        }


        // NAME (Requerido: > 5)
        if (!dataMap.TryGetValue("name", out string name) || name.Length < 5)
        {
            esValidoTotal = false;
        }

        // STATE (Requerido: > 5)
        if (!dataMap.TryGetValue("state", out string state) || state.Length < 5)
        {
            esValidoTotal = false;
        }

        // AGE (Requerido: >= 18)
        if (dataMap.TryGetValue("age", out string ageStr))
        {
            // Si es O el número es menor de 18, error.
            if (!int.TryParse(ageStr, out int ageNum) || ageNum < 18)
            {
                esValidoTotal = false;
            }
        }
        else
        {
            // age no existe, error.
            esValidoTotal = false;
        }

        //ZIPCODE si existe,es version 4.0
        if (dataMap.TryGetValue("zipcode", out string zip))
        {
            usaVersion40 = true;
            // Valida que sean 5 digitos .
            if (!Regex.IsMatch(zip, @"^\d{5}$"))
            {
                esValidoTotal = false;
            }
        }

        //STATUS si existe,es version 4.0
        if (dataMap.TryGetValue("status", out string status))
        {
            usaVersion40 = true;
            string statusLower = status.ToLower();
            // Solo "soltero" o "casado".
            if (statusLower != "soltero" && statusLower != "casado")
            {
                esValidoTotal = false;
            }
        }


        string version = usaVersion40 ? VERSION_4_0 : VERSION_3_3;
        string resultado = esValidoTotal ? RESULTADO_EXITO : RESULTADO_ERROR;

        return $"Version {version}|{resultado}";
    }
}