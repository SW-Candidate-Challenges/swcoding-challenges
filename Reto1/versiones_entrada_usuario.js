//Reto 1: Versiones - Con entrada de usuario
// Diego Eduardo Ramos Gutiérrez

// Use el modulo "readline" para leer datos en consola
const readline = require("readline");

// Esto nos ayuda a crear y configurar una interfaz de lectura para la comunicación usuario - consola.
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});

// Mi función principal que es la misma logica que la version hardcodeada. 
function retoVerisones(data) {

    // Aquí la cadena se convierte en un arreglo de pares
    const pares = data
    .split('|')     // Use este metodo para separar los campos (clave:valor)
    .map(text => text.split(':'))       // Este metodo lo use para separar los campos de cada registro ("clave:valor", "clave:valor")

    // Aqui el arreglo se convierte en un objeto
    const o = Object.fromEntries(pares);

    // Aqui se detemrina la versión según los creiterios: "Si existe Zipcode o status: versión 4.0 y si estos campos no existen: versión 3.3"
    const version = (o.zipcode || o.status) ? "4.0" : "3.3";

    // Aplicamos las validaciones de las instrucciones del reto, como ejemplo: "name: Debe estar presente y tener al menos 5 caracteres."
    const isValid =
        o.name?.length >= 5 &&
        parseInt(o.age) >= 18 &&
        o.state?.length >= 5 &&
        (!o.zipcode || /^\d{5}$/.test(o.zipcode)) &&
        (!o.status || /^(soltero|casado)$/i.test(o.status));

    // Por ultimo aquí devolvemos un string con el reultado (Version {version|resultado})
    return `Version ${version}|${isValid ? "Success" : "Error"}`;
}

// Aquí es la sección de datos de entrada por el usuario.

rl.question("Ingresa los datos en formato clave:valor|clave:valor ->", (respuesta) => {

    // Se llama a la función con lo que ingreso el usuario.
    const resultado = retoVerisones(respuesta);

    console.log(resultado);

    rl.close();
})