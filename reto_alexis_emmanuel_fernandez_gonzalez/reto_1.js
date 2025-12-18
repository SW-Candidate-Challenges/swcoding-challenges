/**
 * En este codigo en lenguaje JavaScript se implementa una función que procesa una cadena de datos y determina la validez de la información basada en ciertos criterios
 * Esta función recibe una cadena de datos en el formato clave:valor|clave:valor|clave:valor|... y devuelve el resultado indicando si los datos son válidos y la versión de la validación aplicada.
 * La cadena value contiene diferentes pares clave:valor separados por |.
 * La funcion valida cada par basado en los siguientes criterios:
 * name: Debe estar presente y tener al menos 5 caracteres.
 * age: Debe ser un número mayor o igual a 18.
 * state: Debe estar presente y tener al menos 5 caracteres.
 * zipcode: Debe ser un código postal válido de 5 dígitos.
 * status: Solo acepta los valores soltero o casado (sin importar mayúsculas o minúsculas).
 * La función debe devolver un string con el formato Version {version}|{resultado}, donde:
 * version será 4.0 si se encuentra zipcode o status, o 3.3 si estos no están presentes.
 * resultado será Success si todos los valores son válidos, de lo contrario, Error.
 * Nombre del reto: Versiones
 */
function validarDatos(value) {
    const datos = value.split('|'); // Separamos los pares clave:valor usando el delimitador |
    let name = '';
    let age = 0;
    let state = '';
    let zipcode = '';
    let status = '';
    let tieneZipcodeOStatus = false;
    for (let dato of datos) { // Iteramos sobre cada par clave:valor
        const [clave, valor] = dato.split(':'); // Separamos la clave y el valor usando el delimitador : y destructuramos
        switch (clave) { //usamos switch para asignar los valores a las variables correspondientes y 
            case 'name':
                name = valor;
                break;
            case 'age':
                age = parseInt(valor, 10); // Convertimos el valor de age a un numero entero
                break;
            case 'state':
                state = valor;
                break;
            case 'zipcode':
                zipcode = valor;
                tieneZipcodeOStatus = true; // Indicamos que zipcode esta presente
                break;
            case 'status':
                status = valor;
                tieneZipcodeOStatus = true; // Indicamos que status esta presente
                break;
        }
    }
    let esValido = true;
    if (name.length < 5) esValido = false;
    if (isNaN(age) || age < 18) esValido = false; // isNaN verifica si age no es un numero y tambien si es menor a 18
    if (state.length < 5) esValido = false;
    if (zipcode && (zipcode.length !== 5 || isNaN(zipcode))) esValido = false; // verifica que zipcode tenga exactamente 5 digitos 
    if (status) {
        const valor = status.toLowerCase(); // convierte el status a minusculas para comparacion pero no afecta que sea mayuscula o minuscula
        if (valor !== 'soltero' && valor !== 'casado') esValido = false; // verifica que status sea soltero o casado
    }
    const version = tieneZipcodeOStatus ? '4.0' : '3.3'; // determina la version segun la presencia de zipcode o status
    const resultado = esValido ? 'Success' : 'Error'; // determina el resultado final
    return `Version ${version}|${resultado}`; // devuelve el resultado en el formato requerido
}
// Ejemplos de uso de la funcion
console.log(validarDatos("name:Alexis|age:25|state:Orizaba|zipcode:94460|status:soltero"));
console.log(validarDatos("name:Ana|age:17|state:LA"));
console.log(validarDatos("name:Juan|age:30|state:Paris|status:casado"));
console.log(validarDatos("name:Lu|age:22|state:Francia|zipcode:1234"));