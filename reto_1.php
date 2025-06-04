<?php
/*¡Bienvenido al reto de programación! 
Nombre del reto: Versiones
En este desafío, deberás implementar una función en el lenguaje de tu preferencia que procese una cadena de datos y determine la validez de la información basada en ciertos criterios.

Descripción del Reto
Tu tarea es implementar una función que reciba una cadena de datos en el formato clave:valor|clave:valor|... y devuelva un resultado indicando si los datos son válidos y la versión de la validación aplicada.

La cadena value contendrá diferentes pares clave:valor separados por |.

Deberás validar cada par basado en los siguientes criterios:

name: Debe estar presente y tener al menos 5 caracteres.
age: Debe ser un número mayor o igual a 18.
state: Debe estar presente y tener al menos 5 caracteres.
zipcode: Debe ser un código postal válido de 5 dígitos.
status: Solo acepta los valores soltero o casado (sin importar mayúsculas o minúsculas).
La función debe devolver un string con el formato Version {version}|{resultado}, donde:

version será 4.0 si se encuentra zipcode o status, o 3.3 si estos no están presentes.
resultado será Success si todos los valores son válidos, de lo contrario, Error.


Ejemplos de Entrada correctos:

name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero

name:PedroL|age:22|state:Nayarit

Ejemplos de Entrada incorrectos:

name:Ana|age:19|state:Yucatán|zipcode:1234|status:Casado

name:Roberto|age:17|state:Sonora|status:Soltero

name:Elisa|age:30|state:DF|zipcode:99999|status:divorciado
*/

function validarDatos($cadena) {
    $pares = explode("|", $cadena);
    $datos = [];

    foreach ($pares as $par) {
        list($clave, $valor) = explode(":", $par);
        $datos[trim(strtolower($clave))] = trim($valor);
    }

    $version = (isset($datos['zipcode']) || isset($datos['status'])) ? '4.0' : '3.3';

    if (!isset($datos['name']) || strlen($datos['name']) < 5) {
        return "Version $version|Error";
    }

    if (!isset($datos['age']) || !is_numeric($datos['age']) || intval($datos['age']) < 18) {
        return "Version $version|Error";
    }

    if (!isset($datos['state']) || strlen($datos['state']) < 5) {
        return "Version $version|Error";
    }

    if (isset($datos['zipcode']) && !preg_match('/^\d{5}$/', $datos['zipcode'])) {
        return "Version $version|Error";
    }

    if (isset($datos['status']) && !in_array(strtolower($datos['status']), ['soltero', 'casado'])) {
        return "Version $version|Error";
    }

    return "Version $version|Success";
}


$casos = [

    "name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero",
    "name:PedroL|age:22|state:Nayarit",

    "name:Ana|age:19|state:Yucatán|zipcode:1234|status:Casado",         // name corto, zipcode no válido
    "name:Roberto|age:17|state:Sonora|status:Soltero",                 // age menor de 18
    "name:Elisa|age:30|state:DF|zipcode:99999|status:divorciado",      // state corto, status inválido
];

foreach ($casos as $index => $entrada) {
    echo "Caso " . ($index + 1) . ":\n";
    echo "Entrada: $entrada\n";
    echo "Salida: " . validarDatos($entrada) . "\n\n";
}

?>