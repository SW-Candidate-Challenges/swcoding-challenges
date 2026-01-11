const sumarNumeros = (a, b) => {

    //validar que ambos numeros sean decimal con un metodo, y retornar el resultado directo
    return (Number.isInteger(a) && Number.isInteger(b))
        ? `El resultado de la suma es: ${a + b} SW` 
        : `Ambos parámetros deben ser números enteros.`

};

console.log(sumarNumeros(5, -10))
