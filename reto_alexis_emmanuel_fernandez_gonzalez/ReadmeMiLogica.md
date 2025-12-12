# Mi Logica

Hola soy Alexis Emmanuel y en este dm ire describiendo la logica de las soluciones para los retos que fui completando

# Reto 1 

En este primer reto nos pidieron realizaru una funcion que procese y valide una cadena de datos y en base a esto valide la version aplicada.
El formato que debia tenera la cadena de datos era la siguiente: clave:valor|clave:valor|... siento separado el value en pares clave:value por "|" en cada criterio.

Dentro de los criterios que se pidieron fue: 
name: Debe estar presente y tener al menos 5 caracteres.
age: Debe ser un número mayor o igual a 18.
state: Debe estar presente y tener al menos 5 caracteres.
zipcode: Debe ser un código postal válido de 5 dígitos.
status: Solo acepta los valores soltero o casado (sin importar mayúsculas o minúsculas).

La función debia devolver un string con el formato Version {version}|{resultado}, donde:
version será 4.0 si se encuentra zipcode o status, o 3.3 si estos no están presentes.
resultado será Success si todos los valores son válidos, de lo contrario, Error.

Lo primero que hice fue documentar mi codigo para que entendieran el porque de dicho codigo, mostrando las instrucciones y el lenguaje que se uso para la prueba.
Despues de esto comence a crear la funcion "validarDatos(value){}" dentro cree la constante "datos" la cual se encargaria de separar por medio de ".split" los pares de clave:valor agregando el separador pedido "|".
Luego seguimos creando las variables para: "name", "age", "state", "zipcode", "status" y por ultimo una para validar si cuenta con "zipcode" o "status" llamada "tieneZipcodeOStatus" que es boolean.
Ahora cree un for of para iterar en "datos" y luego  destructurar clave:valor con la variable de "dato" siendo estas separada con split y ":" que es como estan representados y queda en dos partes.
Despues usando switch para asignar los valores a las variables correspondientes si es que estan presentes y en "age" lo convertimos a un numero entero.
Luego cree valicaciones donde primero cree un validador boolean para determinar que es valio y que no.
Empezamos por el nombre pidiendo que tenga mas de cinco letras para poder ser valido.
Seguido de eso vamos por age el cual debemos validar que sea un numero y que sea mayor de 18.
Ahora el "state" tambien debe ser mayor a 5 letras para ser valido y llegando a "zipcode" validamos que haya un zipcode y que no valide si no es de 5 caracteres o no es un número.
Para "status" hice que sean minusculas y que solo haya 2 opciones validas: "soltero" o "casado".
Crearemos ahora una constante para la version, usando una condicion para determinar si es "4.0" o "3.3" basada en la variable "tieneZipcodeOStatus".
Ahora para mostrar si el resultado era "Succes" o "Error" cree un variable llamada "resultado" que por una condicion indicaba si era valido.
Asi la funcion "validarDatos" mostraria un mensaje indicando la version y el resultado despues de haber analizado la cadena de datos.
Como ultimo solo quedo agregar un "console.log(validarDatos("name:Alexis|age:25|state:Orizaba|zipcode:94460|status:soltero"));"


# Reto 2

En este segundo reto nos pidieron realizar una funcion que sume 2 números enteros y que muestre un mensaje cuando no cumpla con la función,
si este cumple la funcion debe retornar un string que muestre:  "El resultado de la suma es: Resuldato SW".

Lo primero que hice fue documentar mi codigo para que entendieran el porque de dicho codigo, mostrando las instrucciones y el lenguaje que se uso para la prueba.
Como segundo paso cree la funcion sumarNumeros(a,b) donde pedimos 2 valores, seguido de esto use un if para la crear la condicion que necesitamos.
Usando !Number.IsInteger() para que los valores que este reciba comprueben que es entero, seguido de "||" para que complementa la condicion de los 2 valores.
Asi nos encargamos de que si no es un entero muestre el mensaje: "Error: Ambos parametros deben ser numeros enteros." y si la condicion no cumple pase al "else".
Es aqui donde cree una constante que almacene el resultado de los 2 valores: a + b , luego cree otra constante porque el reto pedia que devolviera un string.
Despues de estar acabada la funcion solo las imprimo con el "console.log(sumarNumeros(a,b))" para demostrar que cumple con los requisitos del reto.