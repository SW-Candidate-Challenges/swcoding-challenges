// RetoVersiones.

Console.WriteLine("\n--- Reto 1: Versiones ---");
Console.WriteLine("---------------------------------------------");

// PRUEBAS SUCCESS
Console.WriteLine("\n--- Ejemplos de Entrada Correctos ---");

// Caso 1: Completo y Válido. Debe dar: Version 4.0|Success
string caso1 = "name:AndreaG|age:29|state:Jalisco|zipcode:44100|status:Soltero";
Console.WriteLine("Caso 1 (Esperado 4.0|Success): " + RetoVersiones.ProcesarDatos(caso1));

// Caso 2: Válido, sin campos 4.0. Debe dar: Version 3.3|Success
string caso2 = "name:PedroLa|age:22|state:NayaritA";
Console.WriteLine("Caso 2 (Esperado 3.3|Success): " + RetoVersiones.ProcesarDatos(caso2));

Console.WriteLine("---------------------------------------------");

// PRUEBAS CON ERROR
Console.WriteLine("\n--- Ejemplos de Entrada Incorrectos ---");

// Caso 3: Nombre y Zipcode malos. Debe dar: Version 4.0|Error
string caso3 = "name:Ana|age:19|state:Yucatán|zipcode:1234|status:Casado";
Console.WriteLine("Caso 3 (Esperado 4.0|Error): " + RetoVersiones.ProcesarDatos(caso3));

// Caso 4: Edad menor de 18. Debe dar: Version 4.0|Error
string caso4 = "name:Roberto|age:17|state:Sonora|status:Soltero";
Console.WriteLine("Caso 4 (Esperado 4.0|Error): " + RetoVersiones.ProcesarDatos(caso4));

// Caso 5: Estado y Status malos. Debe dar: Version 4.0|Error
string caso5 = "name:ElisaG|age:30|state:DF|zipcode:99999|status:divorciado";
Console.WriteLine("Caso 5 (Esperado 4.0|Error): " + RetoVersiones.ProcesarDatos(caso5));


Console.WriteLine("---------------------------------------------");

Console.WriteLine("\nFin de las pruebas.");