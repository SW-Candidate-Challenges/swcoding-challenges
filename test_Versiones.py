import unittest                         # Libreria de python que nos apoya en el proceso de pruebas unitarias
from Versiones import versionesString   # Importamos la funcion del archivo de Versiones.py

class TestVersiones(unittest.TestCase):
    def test_correcto_zipcodestatus(self):  
        resultado = versionesString("name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero")
        self.assertEqual(resultado, "Version 4.0|Success")

    def test_correcto_nozipcodestatus(self):
        resultado = versionesString("name:PedroL|age:22|state:Nayarit")
        self.assertEqual(resultado, "Version 3.3|Success")

    def test_incorrecta_zipcodemal(self):
        resultado = versionesString("name:Ana|age:19|state:Yucatán|zipcode:1234|status:Casado")
        self.assertEqual(resultado, "Version 4.0|Error")

    def test_incorrecta_agemenor(self):
        resultado = versionesString("name:Roberto|age:17|state:Sonora|status:Soltero")
        self.assertEqual(resultado, "Version 4.0|Error")

    def test_incorrecta_statusdiferente(self):
        resultado = versionesString("name:Elisa|age:30|state:DF|zipcode:99999|status:divorciado")
        self.assertEqual(resultado, "Version 4.0|Error")

if __name__ == '__main__':
    unittest.main()
