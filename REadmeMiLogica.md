# Reto de Programación
Bienvenido a mi solucion realizada para el reto "Version" de SWCoding-Challenges.
En este reto se tuvo que validar una cadena de informacion en base a multiples criterios:

Reglas de Validacion:
    name: Debe estar presente y tener al menos 5 caracteres.
    age: Debe ser un número mayor o igual a 18.
    state: Debe estar presente y tener al menos 5 caracteres.
    zipcode: Debe ser un código postal válido de 5 dígitos.
    status: Solo acepta los valores soltero o casado (sin importar mayúsculas o minúsculas).
    La función debe devolver un string con el formato Version {version}|{resultado}, donde:

    version será 4.0 si se encuentra zipcode o status, o 3.3 si estos no están presentes.
    resultado será Success si todos los valores son válidos, de lo contrario, Error.

Tecnologia Utilizada:
    Lenguaje: C# (.NET 8)
    Herramientas: LINQ, Expresiones Regulares, Diccionarios

Logica de implementacion:
    Para dar solucion a este problema se utilizo LINQ (Separacion de la cadena) y Expresion Regular (Validacion de Codigo Postal).

    Como primer paso se separo cada uno de los valores de la cadena recibida a traves de su separador "|" utilizando el metodo String.Split de C# para posteriormente generar un Diccionario de pares Clave - Valor con LINQ a fin de realizar la validacion de cada criterio.

    Una vez generado el diccionario se realizo la validacion de la version a traves de los Criterios TieneZipcode || TieneStatus para diferenciar entre versiones.

    Posteriormente se valido cada uno de los valores en base a sus criterios, para el caso del Zipcode se utilizo una Expresion Regular para definir un formato de 5 digitos numericos.

    Para el caso de estatus opte por convertir el valor en minusculas para facilitar la comparacion con los criterios "soltero" y "casado".

Al finalizar, la función devuelve el mensaje correspondiente según los datos recibidos.
