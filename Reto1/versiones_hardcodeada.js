// Reto 1: Versiones - harcodeado
// Diego Eduardo Ramos Gutiérrez

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

// Prueba = Success - version 4.0
const entry = "name:Diego|age:23|state:Jalisco|zipcode:45428|status:Soltero"

// Prueba = Error - version 4.0
const entry2 = "name:Diego|age:17|state:Jalisco|zipcode:45428|status:Soltero"

// Prueba = Success - version 3.3
const entry3 = "name:Diego|age:23|state:Jalisco"

// Prueba = Error - version 3.3
const entry4 = "name:Diego|age:17|state:Jalisco"


console.log(retoVerisones(entry));
console.log(retoVerisones(entry2));
console.log(retoVerisones(entry3));
console.log(retoVerisones(entry4));