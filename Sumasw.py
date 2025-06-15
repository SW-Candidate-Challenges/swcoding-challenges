def sumarNumeros(a,b):
    """ Retorna la suma de dos enteros
        Valida que ambos datos ingresados sean enteros
        Si son enteros retorna el resultado con un mensaje, sino retorna otro mensaje"""                                  
    if isinstance(a,int) and isinstance(b,int):     #isinstance (obj,type) -> valida si el objeto insertado es del tipo que indicamos en este caso a o b y que sean enteros
        resultado = a + b                                                   
        mensaje = f"El resultado es {resultado} SW"  #print(f"") permite concatenar variables entre llaves en lugar de "mensaje "+variable+"continuacion mensaje"                  
        return mensaje                              #retornamos el mensaje                       
    else:                                                                   
        mensaje = "Ambos parámetros deben ser números enteros."      
        return mensaje                              #retornamos el mensaje                         
    

help(sumarNumeros)
sumarNumeros(8,4)
sumarNumeros(0,0)
sumarNumeros(123,877)
sumarNumeros(5.5,2)
sumarNumeros("10",2)
sumarNumeros(8,None)
sumarNumeros([],{})
