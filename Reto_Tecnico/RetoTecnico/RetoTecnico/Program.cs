using Versiones;

Console.WriteLine("*** Reto de Versiones ***");
Console.WriteLine();

//Casos Validos
string cadena = "name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero";     // Version 4.0|Success - Cadena Completa
//string cadena = "name:PedroL|age:22|state:Nayarit";                                // Version 3.3|Success - Sin zip ni status

//Casos Invalidos
//string cadena = "name:Ana|age:19|state:Yucatán|zipcode:1234|status:Casado";        // Version 4.0|Error - Name y Zip incorrectos
// string cadena = "name:Roberto|age:17|state:Sonora|status:Soltero";                // Version 4.0|Error - Menor de edad
// string cadena = "name:Elisa|age:30|state:DF|zipcode:99999|status:divorciado";     // Version 4.0|Error - State y Status incorrecto
var procesador = new ProcesadorVersiones();
string resultado = procesador.Procesar(cadena);

Console.WriteLine("Los datos Ingresados son:");
Console.WriteLine(cadena);
Console.WriteLine();


Console.WriteLine($"Resultado: {resultado}");
Console.WriteLine();

Console.WriteLine("Presiona cualquier tecla para salir.....");
Console.ReadKey();