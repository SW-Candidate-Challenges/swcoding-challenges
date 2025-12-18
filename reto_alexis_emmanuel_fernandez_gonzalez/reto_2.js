/** 
 * En este codigo en lenguaje JavaScript se implenta un funcion que recibe 2 numeros enteros, los suma y devuelve el mensaje indicando el resultado.
 * Si alguno de los parametros no es un numero entero, la funcion debe devolver el mensaje: "Error: Ambos parametros deben ser numeros enteros."
 * Si ambos parametros son numeros enteros, la funcion debe sumar los dos números y retornar un string con el siguiente formato: 
 * "El resultado de la suma es: Resultado SW", donde Resultado es la suma de a y b y "SW" son las iniciales.
 * Nombre del reto: SumasW 
**/
function sumarNumeros(a, b) { 
    if (!Number.isInteger(a) || !Number.isInteger(b)) { // Con el !Number.isInteger() verificamos si los parametros no son numeros enteros
        return "Error: Ambos parametros deben ser numeros enteros."; 
    } else {
        const resultado = a + b;
        const string = "El resultado de la suma es: " + resultado + " SW"; // Creamos el string con el formato solicitado
        return string; // Devolvemos el string para ver el resultado
    } 
}
// Ejemplos de uso de la funcion
console.log(sumarNumeros(5,3)); 
console.log(sumarNumeros(-10,5));
console.log(sumarNumeros(4.5,2));
console.log(sumarNumeros(7,'3'));