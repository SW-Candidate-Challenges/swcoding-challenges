using SumaSW;

Console.WriteLine("*** Reto SumaSW ***");

var servicio = new ProcesadorSuma();

//Casos Validos
string resultado = servicio.SumarNumeros(5, 3, out string motivo);        // 8 SW
//string resultado = servicio.SumarNumeros(-10, 4, out string motivo);     // -6 SW
//string resultado = servicio.SumarNumeros(0, 0, out string motivo);       // 0 SW
//string resultado = servicio.SumarNumeros(123, 877, out string motivo);   // 1000 SW


//Casos Invalidos (no enteros)
//string resultado = servicio.SumarNumeros(5.5, 2, out string motivo);    // a es un número decimal
//string resultado = servicio.SumarNumeros("10", 5, out string motivo);   // a es string
//string resultado = servicio.SumarNumeros(8, null, out string motivo);   // b no es un numero.
//string resultado = servicio.SumarNumeros(true, 3, out string motivo);   // a es booleano.
//string resultado = servicio.SumarNumeros(new int[] {}, new object(), out string motivo); // Ambos son tipós incorrectos.

Console.WriteLine(resultado);

if (!string.IsNullOrEmpty(motivo))
{
    Console.WriteLine($"Motivo del error: {motivo}");
}

Console.WriteLine();
Console.WriteLine("Presiona cualquier tecla para salir.....");
Console.ReadKey();