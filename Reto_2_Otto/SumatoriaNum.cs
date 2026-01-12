//Namespace para identificar y mandar a llamar el contenido
namespace Reto_2_Otto{

    //Clase que contiene nuestras funciones
        public class SumatoriaNum {
    //Funcion PUBLICA para que pueda ser accedida en otros scopes
        public string sumarNumeros(object a, object b){

            //Validacion para identifcar que los 2 valores sean enteros
            if(a is int numa && b is int numb){
                //mensaje de resultado
                return $"El resultado de la suma es: {numa + numb} SW";
                //En caso de que los 2 parametros no sean enteros, mandar mensaje de "error"
            } else{
                return "Ambos parámetros deben ser números enteros.";

            }


/*En caso de ser necesario ser mas descriptivos quitar el comentario para saber exactamente que esta mal
    //El problema solo pide mandar un mensaje generico, asi que esto quedara omitido

            string errora = string.Empty;
            string errorb = string.Empty;

            if(a is double && b is double){
                errora = "Ambos valores son decimales";
            }else if(a is double){
                errora = "Numero A es decimal ";
            }else if(b is double){
                errorb = "Numero B es decimal";
            }

            if(a is string && b is string){
                errora = "Ambos valores son texto";
            }else if(a is string){
                errora = "Numero A es texto ";
            }else if(b is string){
                errorb = "Numero B es texto";
            }

            if(a is bool && b is bool){
                errora = "Ambos valores son booleanos";
            }else if(a is bool){
                errora = "Numero A es booleano ";
            }else if(b is bool){
                errorb = "Numero B es booleano";
            }

            if(a is null && b is null){
                errora = "Ambos valores son Nulos";
            }else if(a is null){
                errora = "Numero A es Nulo ";
            }else if(b is null){
                errorb = "Numero B es Nulo";
            }

            if(a is not int && b is not int){
                return "Ambos parámetros deben ser números enteros.";
            }else if(a is not int){
                errora = "Numero A no es int ";
            }else if(b is not int){
                errorb = "Numero B no es int";
            }
            return "Ambos parámetros deben ser números enteros. " + errora + errorb;

            */
        }
    }
}



