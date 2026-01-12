
//Se usa el espacio que contiene la funcion, esto es para mantener orden
using Reto_2_Otto;

//Se declara el objeto para mandar a llamar funciones
var SumatoriaNum = new SumatoriaNum();

//Hacemos los casos de Test correctos
Console.WriteLine("Casos Correctos: ");
Console.WriteLine(SumatoriaNum.sumarNumeros(5, 3));
Console.WriteLine(SumatoriaNum.sumarNumeros(-10, 4));
Console.WriteLine(SumatoriaNum.sumarNumeros(0, 0));
Console.WriteLine(SumatoriaNum.sumarNumeros(123, 877));

//Hacemos los casos de Test incorrectos
Console.WriteLine("\nCasos Erroneos: ");
Console.WriteLine(SumatoriaNum.sumarNumeros(5.5, 2));
Console.WriteLine(SumatoriaNum.sumarNumeros("10", 5));
Console.WriteLine(SumatoriaNum.sumarNumeros(8, null));
Console.WriteLine(SumatoriaNum.sumarNumeros(true, 3));
Console.WriteLine(SumatoriaNum.sumarNumeros(new int[] {}, new object{}));


//Para que no se cierre la consola en automatico.
Console.ReadKey();