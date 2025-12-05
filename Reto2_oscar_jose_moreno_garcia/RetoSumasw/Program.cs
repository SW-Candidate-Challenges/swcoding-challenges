// RetoSumasw.


Console.WriteLine("\n--- Reto 2: Sumasw ---");
Console.WriteLine("--------------------------------------------------------------------------");


// VALIDO
Console.WriteLine("Casos Validos:");
Console.WriteLine("Suma 5+3: " + RetoSumasw.SumarNumeros((object)5, (object)3));
Console.WriteLine("Suma -10+4: " + RetoSumasw.SumarNumeros((object)-10, (object)4));
Console.WriteLine("Suma 0+0: " + RetoSumasw.SumarNumeros((object)0, (object)0));
Console.WriteLine("Suma 123+877: " + RetoSumasw.SumarNumeros((object)123, (object)877));

Console.WriteLine("--------------------------------------------------------------------------");

// INVALIDO
Console.WriteLine("\nCasos Invalidos (Deben dar el mensaje de error):");

// Caso 1: Motivo del error: a es un número decimal
Console.WriteLine("Inválido (Decimal 5.5): " + RetoSumasw.SumarNumeros((object)5.5f, (object)2));

// Caso 2: Motivo del error: a es string
Console.WriteLine("Inválido (Tipo String '10'): " + RetoSumasw.SumarNumeros((object)"10", (object)5));

// Caso 3: Motivo del error: b no es un número (null/nil)
Console.WriteLine("Inválido (Null/nil): " + RetoSumasw.SumarNumeros((object)8, null));

// Caso 4: Motivo del error: a es booleano
Console.WriteLine("Inválido (Booleano true): " + RetoSumasw.SumarNumeros((object)true, (object)3));

// Caso 5: Motivo del error: Ambos son tipos incorrectos (Array y Objeto)
Console.WriteLine("Inválido (Array/Objeto): " + RetoSumasw.SumarNumeros((object)new int[0], (object)new object()));

Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine("\nFin de las pruebas.");
