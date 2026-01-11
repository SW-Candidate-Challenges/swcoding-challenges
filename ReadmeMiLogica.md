# Reto 1
En este reto se optó por una función flecha que recibe como parámetro value.

Dentro de esta declaramos nuestras variables como:
- Datos, para separar nuestra cadena usando el método split y convertirlo. - en array separado por "|".
- Versión, e inicializamos con el valor 3.3.
- Resultado, para resultado final.
- Validar, que será un array vacío para insertar los resultados de nuestras validaciones.
- Declaramos 2 variables con booleanos para la revisión de campos obligatorios.
    - tieneName para el nombre.
    - tieneState para el estado.

Después recorremos  a través de un método loop FOREACH datos para volver a usar split y esta vez usar ":" para declarar 2 variables en donde obtenemos la clave y el valor de item recorrido, utilizando toLowerCase para evitar conflictos con las mayúsculas.

Posteriormente usamos la estructura SWITCH dentro de nuestro loop utilizando la clave como argumento, de esta manera dependiendo de la clave que coincida con nuestros "CASE", utilizaremos la variable validar y aplicaremos el método push con una pequeña condición para validar que se cumplan los criterios solicitados.
Además de eso en el caso de "name" y "state" inicializamos un valor booleano para detectar que si existen estos valores en la cadena proporcionada.

Enseguida fuera de nuestra estructura SWITCH utilizaremos una estructura IF en donde nuestra condición sería revisar si la clave es igual a status o zipcode para asignarle el valor a nuestra variable versión correspondiente, dentro de la misma ejecución utilizamos otros 2 IF para detectar status o  zipcode, en donde si en status la clave es soltero o casado, insertamos en nuestra variable Validar TRUE o FALSE para nuestra validación.
En nuestro otro IF la condición ahora será para saber si clave es igual a zipcode y validar de la misma forma si la longitud del código postal es igual a 5.

Después fuera de SWITCH y FOREACH utilizamos un IF en donde pasamos como condición si las variables tieneName o tieneState son diferentes de TRUE, si es así le asignamos el valor de Error a nuestra variable de resultado, de otra manera, a resultado le asignamos el valor que resulte de utilizar el método include utilizando como argumento FALSE para encontrar un valor que coincida, si es asi se asignará el valor de Error, de otra manera le asignaremos Success.

Debajo retornamos el valor utilizando interpolación para devolver que version es y el resultado final.

# Reto 2
En este reto se declara una función flecha llamada sumarNumeros, la cual recibe dos parámetros: a y b.
Dentro de la función, utilizamos un return con un operador ternario para decidir qué valor devolver. La condición emplea el método Number.isInteger, el cual valida si un valor es un número entero.
En este caso verificamos que:
- a sea un número entero
- b sea un número entero

Para esto usamos el operador lógico &&, que significa "y", que nos permite asegurar que ambas condiciones sean verdaderas al mismo tiempo.
Si los dos valores son enteros, devolvemos:
- El resultado de la suma es: ${a + b} SW

De lo contrario, si alguno de los parámetros no es entero, regresamos el mensaje:
- Ambos parámetros deben ser números enteros.


