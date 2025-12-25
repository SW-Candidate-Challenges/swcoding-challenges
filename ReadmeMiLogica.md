Jesus Ignacio Rostro Diaz -> Github user:xZloy
# Problema 1. Explicacion a detalle
El problema 1, que esencialmente es para los junior me parecio bueno, realmente me reto con ciertas cosas...

Este problema me pedía implementar una función para procesar un string, asi que decidi llamarla *versionesString* que recibiera un parámetro *msj*.
 - La funcion recibe una cadena dedatos en formato *clave:valor* separados por |.
 - Así que primeramente definí la función *versionesString(msj):* y empecé procesando el string para separar cada par clave:valor y almacenarlo en un diccionario llamado *datosUsuario*, lo cual facilita acceder a cada dato de forma rápida.
 - Para separar cada clave y su valor utilicé *split("|")* para obtener cada par, y luego *split(":")* para dividir cada par en su clave y su valor correspondiente.
- Usé un contador para llevar registro de cuántos pares hay inicialmente, y a medida que cada clave pasa su validación correcta, *resto 1 al contador.*
Las validaciones implementadas fueron:
- Que el name tenga al menos 5 caracteres.
- Que el age sea mayor o igual a 18.
- Que el state tenga al menos 5 caracteres.
- Que el zipcode, si existe, tenga exactamente 5 dígitos.
- Que el status, si existe, solo pueda ser 'casado' o 'soltero' (ignorando mayúsculas/minúsculas).
- Para definir la versión requerida, se asigna 4.0 si existe zipcode o status en los datos, y 3.3 si no existen.
- Finalmente, si el contador llega a cero, significa que todos los pares pasaron su validación, entonces devuelvo 'Success', si no, devuelvo 'Error'.
- El mensaje final se construye usando f"" para formatear la cadena en el formato solicitado: **'Version {version}|{resultado}'.**

# Problema 2. Explicacion a detalle
El problema 2 la verdad me parecio uno bastante sencillo, asi que procedamos con la explicación.
- Este problema me pedia implementar una funcion llamada **sumarNumeros** que recibiera dos parametros **(a,b)**
- Asi que primeramente defini la funcion **sumarNumeros(a,b):** y desarrolle el codigo
- Almacene en la variable resultado la suma de ambos, pero antes de eso tenia que realizar las validaciones que me pedian
- Realmente solo habia una validacion necesaria que era validar que fueran enteros los parametros ingresados
- Por lo tanto puse un if isinstance(variable_ingresada,tipo_de_dato), por lo que isinstance nos apoya a validar si el dato de la izq es del tipo de dato de la derecha, si pasa el if
- construimos un mensaje formateado con f"" en donde concatenamos la variable del resultado y el mensaje que se nos solicita **'El resultado es {resultado} SW'**
- Si no es un entero entramos en el else, donde retornamos otro mensaje **'Ambos parámetros deben ser números enteros.'**

# Pruebas unitarias. Explicacion a detalle
Las pruebas unitarias son una manera mas automatizada de correr tu codigo y probar si funciona con casos especificos que podrian ocasionar que este falle, 
gracias a que use python existe una libreria llamada unittest que nos permite realizar las pruebas untiarias.
- De cada clase importe la funcion que habia creado, como en **Sumasw.py** importe *sumarNumeros* y de Versiones importe *versionesString*
- Lo siguiente es crear una clase y crear funciones que lo unico que haran es llamar a la funcion importada y ingresarle valores
- Posteriormente con *assertequal* validamos que el resultado obtenido de la llamada a la funcion sea igual que el que esperamos nosotros en el archivo de unittest
- Si es igual recibiremos un mensaje de OK Al final con las pruebas ejecutadas, caso contrario nos indicara en que fallo y cuantos test pasaron o fallaron con failure