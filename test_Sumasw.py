import unittest                         # Libreria de python que nos apoya en el proceso de pruebas unitarias
from Sumasw import sumarNumeros         # Importamos la funcion del archivo de Sumasw.py

class TestSumasw(unittest.TestCase):
    def test_correcto_dosenteros(self):  
        resultado = sumarNumeros(100,155)
        self.assertEqual(resultado, "El resultado es 255 SW")

    def test_correcto_dosenteros(self):
        resultado = sumarNumeros(123,877)
        self.assertEqual(resultado, "El resultado es 1000 SW")

    def test_incorrecta_stringyentero(self):
        resultado = sumarNumeros("10",8)
        self.assertEqual(resultado, "Ambos parámetros deben ser números enteros.")

    def test_incorrecta_brackets(self):
        resultado = sumarNumeros([],{})
        self.assertEqual(resultado, "Ambos parámetros deben ser números enteros.")

    def test_incorrecta_enteroynull(self):
        resultado = sumarNumeros(87,None)
        self.assertEqual(resultado, "Ambos parámetros deben ser números enteros.")

if __name__ == '__main__':
    unittest.main()