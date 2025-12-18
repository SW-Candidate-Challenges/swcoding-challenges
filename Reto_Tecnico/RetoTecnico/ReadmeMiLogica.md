ReadmeMiLogica

Reto: Versiones

Hice una clase llamada ProcesadorVersiones con el método:
Procesar(string cadena) el cual recibe una cadena con el formato de clave:valor
separada por "|" por ejemplo:

string cadena = "name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero";

y regresar un texto con el formato mencionado: Version {version}|{resultado}
en donde la versión puede ser 3.3 o 4.0 y el resultado Success o Error.

Lógica General

1. Primero convierto la cadena a un tipo Dictionary<string, string> esto lo hace 
   el método de ParsearCadena().


2. Después valido el diccionario con el método Validar() y aplico las reglas solicitadas
   ejemplo: 
   name: Debe estar presente y tener al menos 5 caracteres.
   age: Debe ser un número mayor o igual a 18.
   Si alguna de las validaciones falla el método Validar devuelve false y si todas cumplen true.


3. La versión la calcula el método CalcularVersion()
   ∙ si el diccionario tiene la clave "zipcode" o "status" es la version 4.0
   ∙ si no tiene ninguna de esas dos claves es la version 3.3

4. Método Procesar();
   ∙ Llamo a ParsearCadena para obtener el diccionario
   ∙ Llamo a CalcularVersion para saber si es 3.3 o 4.0.
   ∙ Llamo a Validar() para saber si los datos son válidos.
   ∙ Al final solo armo el texto: $"Version {version}|{resultado}"

Pruebas Unitarias

Agregué pruebas unitarias en el proyecto VersionesTest en la clase ProcesadorVersionesTest
ejemplo: Cadena_Completa()
	∙ "name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero"
	  Resultado: "Version 4.0|Success".


--------------------------------------------------------------------------------------------

Reto: SumaSW

Hice una clase llamada ProcesadorSuma con el método llamado:
SumarNumeros(object a, object b, out string motivo)

Este recibe dos parámetros en el reto se mencionaba que fueran de tipo int 
pero en mi caso los recibo como de tipo object para poder probar las 
diferentes validaciones con tipos de datos: string, double, bool, null etc.

Lógica General

1. Primero reviso si a y b son de tipo int, si lo son se suma y regresa el texto ejemplo:
   Ejemplo el resultado de la suma es: 8 SW"; en este caso el motivo se queda vacío.

2. Si no son los dos parámetros enteros, se considera como invalido y se regresa siempre 
   el texto: "Ambos parámetros deben ser números enteros." y en el parámetro motivo se indica
   la causa, por ejemplo:
   "a es un número decimal", "a es string", "b no es un número", etc.

Pruebas Unitarias.   

Agregue pruebas unitarias en el proyecto SumaSW en la clase ProcesadorSumaTest
ejemplo: SumarNumeros_AmbosEnteros()
	∙ Verifica que con 5 y 3 regrese: "El resultado de la suma es: 8 SW"
	
Cada prueba revisa que el texto principal sea correcto y que el parámetro motivo
coincida con la descripción que se espera del tipo de error.


De esta forma cumplo con la idea de los retos Versiones y SumaSW.
