import unittest

""""
Este programa se implementa una función que recibe dos números
enteros, los suma y devuelve un mensaje indicando el resultado
sea correcto o incorrecto
"""

def sumarNumeros(a,b): #definimos nuestra funcion junto con los parámetros a considerar únicamente

    errores=[] #creamos nuestra lista errores con el propósito de almacenar los tipos de dato ingresados a manera de poder imprimirlos después
    if type(a) != int or type(a) == bool:
        errores.append("a es de tipo " + str(type(a))) #añadimos el tipo de dato a a nuestra lista
    if type(b) != int or type (b) == bool:
        errores.append("b es de tipo " + str(type(b))) #añadimos el tipo de dato b a nuestra lista
    if errores:
        return "Ambos parámetros deben ser números enteros. " + " y ".join(errores) #gracias a nuestra lista complementamos el mensaje de error 
    else:
        Resultado = a+b #al ser la opcion correcta y restante luego de validar los datos realizamos la operacion suma
        return "El resultado de la suma es: " + str(Resultado) + " SW" #retornamos el resultado añadido al mensaje de operacion correcta (convertimos a str)

"""
En esta siguiente seccion se añaden las Pruebas Unitarias al codigo
"""

class TestSumNum(unittest.TestCase):
    
    def test_valid_sum(self):
        self.assertEqual(sumarNumeros(983,783),"El resultado de la suma es: 1766 SW");
        self.assertEqual(sumarNumeros(-99,3),"El resultado de la suma es: -96 SW");
        self.assertEqual(sumarNumeros(1001,-1001),"El resultado de la suma es: 0 SW");
        self.assertEqual(sumarNumeros(10.34,900),"Ambos parámetros deben ser números enteros. a es de tipo <class 'float'>");
        self.assertEqual(sumarNumeros("numero",2),"Ambos parámetros deben ser números enteros. a es de tipo <class 'str'>");
        self.assertEqual(sumarNumeros(-10,None),"Ambos parámetros deben ser números enteros. b es de tipo <class 'NoneType'>");
        self.assertEqual(sumarNumeros(0,True),"Ambos parámetros deben ser números enteros. b es de tipo <class 'bool'>");

"""
En las pruebas utilizamos la funcion Equal para verificar que la operacion testeada tenga como mismo valor lo que en nuestra función
realizamos paso a paso pero de manera automática con valores antes ingresados y listos para ejecutar desde terminal.
"""





