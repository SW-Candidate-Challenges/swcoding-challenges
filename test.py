# test pruebas unitarias 

from reto2 import sumarNumero

def test_suma():
    #prueba caso normal
    assert sumarNumero (2, 3) == "El resultado de la suma es : 5 SW"

def test_sumaNegativa ():
    #prueba numeros negativos
    assert sumarNumero (-4, 10) == "El resultado de la suma es : 6 SW"

def test_decimal():
    #prueba error decimal
    assert sumarNumero (5.6, 4) == "Ambos parametros deben ser numeros enteros"

def test_texto():
    #texto y booleanos 
    assert sumarNumero("5", 2) == "Ambos parametros deben ser numeros enteros"
    assert sumarNumero(True, 2) == "Ambos parametros deben ser numeros enteros"
    