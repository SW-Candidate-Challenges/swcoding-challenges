//Jose Angel Lozano Santiago
//primero tengo que crar la funcion para sumar los numeros que se almacenaran en a y b
function sumarNumeros(a,b){
    //con la funcion Number.isInteger podemos verificar que el numero sea un entero y no uno con decimiales
    // y con un typeof podemos ver que tipo es por si escriben otra cosa que no sea un numero
    // esto lo puedo hacer con un if para que se cumplan las condiciones
    if(typeof a !== "number" || !Number.isInteger(a)){ //utilizo el operador logico !== para cuando sea diferente o de distinto tipo al solicitado
        return "Ambos parámetros deben ser números enteros." // si el operador identifica alguno diferente entonces mandamos el mensaje 
    }
    //ahora verificamos b con otro if
    if(typeof b !== "number" || !Number.isInteger(b)){
    return "Ambos parámetros deben ser números enteros."
    }
    // ahora ya verificado que ambos numeros son enteros hacemos la sumatoria
    //creamos una contante donde sumamos a + b

    const resultado = a + b; // en la const llamada resultado se almacenara el resulatdode a + b
    // indicamos el meaje con el reslutado 
    return "El resultado de la suma es: " + resultado + "SW" //agregamos SW que son las iniciales

}
// ya por ultimo hacemos pruebas para corroborar que funcione
    // en este caso utilizare las que pusieron en casos validos para asi estar mas seguro de que hace lo pedido 
    //en estos casos deberia seguir con la suma y arrojar el resultado
    console.log(sumarNumeros(5, 3));
    console.log(sumarNumeros(-10, 4));
    console.log(sumarNumeros(0, 0));
    console.log(sumarNumeros(123, 877));
    //en estos casos deberia de mandar el mensaje que ponga los numeros enteros
    console.log(sumarNumeros(5.5, 2));
    console.log(sumarNumeros("10", 5));
    console.log(sumarNumeros(8, null));
    console.log(sumarNumeros([], {}));