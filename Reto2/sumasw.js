// Reto 2: Sumasw
// Diego Eduardo Ramos Gutiérrez

// Se usa el modulo readline para leer datos en cosola
const readline = require("readline");

// Esto nos ayuda a crear y configurar una interfaz de lectura para la comunicación usuario - consola.
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});

// La función "sumarNumeros" recibe 2 valores "a y b"
const sumarNumeros = (a, b) =>
    // Desde aqui se valida que el valor ingresado sea un número entero y se usa un operador ternario para validar que se cumpla la condición.
    (!Number.isInteger(a) || !Number.isInteger(b))
        ? "Ambos párametros deben ser números enteros."
        : `El resultado de la suma es: ${a + b} SW`;

// Aquí es la sección de datos de entrada por el usuario.
rl.question("Ingresa el primer número: ", num1 => {
    rl.question("Ingresa el segundo número: ", num2 => {

        // Se convierte a Number
        const a = Number(num1);
        const b = Number(num2);

        // Se imprime el resultado
        console.log(sumarNumeros(a, b));

        rl.close

    })
})