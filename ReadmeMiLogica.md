# Reto 1
Para resolver este reto creando al clase Reto1, en la cual agregué las funciones de "Main" y la función de "validarVersion".
Dentro de la función de Main agregué un arreglo que contenía todos los datos como ejemplo y posteriormente utilicé un ciclo "for" para recorrer todo el arreglo de los datos, e individualmente envíar cada conjunto de datos llamando a la función para verificar la versión y la validez de los datos.

## Función "validarVersion"
La función principalmente se encarga de utilizar banderas para verificar si los datos son correctos, desde verificar el tamaño de la cadena, hasta validar la igualdad de las cadenas.
Se utilizó principalmente un switch - case para identificar que clave estabamos verificando, haciendo uso también de la función Split para cortar los strings y separar los datos.

## Mi lógica
El reto lo abordé desde una forma en que se me hizo útil hacer mucho uso de banderas, ya que el reto trataba principalmente de verificar si eran validos o no, se puede tomar desde un punto de vista verdadero/falso, de esta forma solo tenía que ver si los datos cumplian con los requsitos que indicaban las instrucciones, y posteriormente identificar si los datos eran validos (Si las banderas eran todas true) o si no lo eran (alguna bandera era false), otro reto fue el cortar las cadenas correctamente, ya que los delimitadores eran los mismos para separar datos y también para separar clave y valor, de esta forma decidi cortar primero los datos completos y posteriormente separarlos en clave y valor para tener un control más preciso sobre ellos.

## Mi lógica

# Reto 2
Comencé mi código creando una clase llamada Reto2, la cual contiene dentro las funciones de "Main" y la función "SumarNumerosEnteros".
Dentro de la función Main utilicé la consola para indicarle al usuario lo que debe ingresar y posteriormente guardé los datos ingresados en variables haciendo uso de Console.ReadLine.
Una vez guardados los dos datos ingresados, llamo a la función de "SumarNumerosEnteros" (Dentro de un Console.WriteLine, para posteriormente imprimir en consola el string que retorne la función), y le paso como parámetros los datos que se ingresaron.

## Función "SumarNumerosEnteros"
La función recibe como parámetros dos variables tipo "object" (Que permite guardar cualquier tipo de valor).
Posteriormente creo una variable de tipo string para guardar el texto (string) del resultado, tanto como un resultado válido, como uno no válido.
Después, creo dos banderas para verificar la congruencia de los datos recibidos. Dentro de estas banderas trato de convertir los valores de los datos en enteros, si es que se puede, para eso utilizo la función int.TryParse(), y dentro de la función, primero verifico que los datos no sean nulos haciendo uso del operador "?" y convirtiendolo en string para que pueda convertirse en entero, finalmente guardo la salida (En este caso el valor de los datos) en una variable extra "numeroA" y "numeroB".
Posteriormente se verifican las banderas, si ambas banderas son verdaderas significa que los dos datos son enteros y entra al bloque verdadero del if, donde se suman ambos números enteros y se guardan en la variable "resultadoSuma" y finalmente guarda en la variable de resultado el texto con el resultado de los dos números sumados.
En caso de que alguna de las banderas no sea verdadera significa que un dato no es de tipo entero, por lo que guarda en su resultado un texto explicando que ambos datos no son números enteros.

## Mi lógica
Creo que el reto puede abordarse de diferentes formas, la forma más fácil de abordarlo sería declarar todas las variables como entero y entonces no tendría que haber un texto de error, ya que la función solamente permitiría recibir números enteros. Sin embargo, si lo abordamos de esta forma, el programa sería bastante inestable, ya que en este caso (Como lo plantee yo, ingresando datos desde la consola.) puede ser posible que el usuario ingrese algo más que no sean números enteros y eso ocasionaría que el programa arrojara un error. Así que viendolo desde un punto de vista más robusto y que pueda cubrir fallos, agregué dentro de la función de suma las banderas para verificar si los datos son enteros, de esta forma, la misma función decide si los datos deben sumarse o no y en caso de que no, externarle al usuario que ambos datos deben ser números enteros. Esto cubre especialmente los errores que pueda cometer el usuario y hace que el programa sea más resistente a fallos.