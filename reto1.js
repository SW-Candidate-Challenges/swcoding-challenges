//implementar función

const validacion = (value) => {
  const datos = value.split("|"); //separar items en un array por | 
  let version = "3.3";
  let resultado;
  let validar = []; //array para validacion de errores

  //campos que son obligatorios
  let tieneName = false;
  let tieneState = false;

  //recorrer nuestro nuevo array
  datos.forEach((element) => {
    const pares = element.split(":"); //separar items en un array por :
    const clave = pares[0].toLowerCase(); //obtener la clave en minuscula
    const valor = pares[1].toLowerCase(); //obtener valor en minuscula

    switch (clave) {
      //validar que las entradas cumplan 
      case "name":
        validar.push(valor.length >= 5); //verificar longitud y existencia
        tieneName = true;
        break;
      case "age":
        validar.push(parseInt(valor, 10) >= 18); //Nos aseguramos de que sea un numero
        break;
      case "state":
        validar.push(valor.length >= 5);  //verificar longitud y existencia
        tieneState = true;
        break;
    }

    //si existen estos campos actualizar la version
    if (clave == "status" || clave == "zipcode") {
      version = "4.0";
      //como si existen validamos ambos
      if(clave == "status"){
        validar.push(valor == "soltero" || valor == "casado");
      }
      if(clave == "zipcode"){
        validar.push(valor.length === 5);
      }
    }
  });

  // verificar los campos obligatorios y declarar el resultado
  if (!tieneName || !tieneState) {
    resultado = "Error";
  } else {
    resultado = validar.includes(false) ? "Error" : "Success"; // revisar si no hay ningun error en nuestro array
  };

  //retornar resultados
  return `{${version}}|{${resultado}}`;
};

console.log(validacion("name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero"));