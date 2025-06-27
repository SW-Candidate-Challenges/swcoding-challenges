

def sumarNumero (a, b):

    """
    Ejercicio para suma de 2 valores enteros de ser asi crea mensaje con resultado 
    de no ser asi devuelve error 
    """

# verificacion de int 

    if type (a) is not int or type(b) is not int:
        return "Ambos parametros deber ser numeros enteros"
    
# calculo de la suma y mensaje 

    return f"El resultado de la suma es {a + b} SW"

# Ingreso de parametros y ciclo 

if __name__ == "__main__":
    try: 
        a = int(input("Ingrese el primer numero"))
        b = int(input("Ingrese el segundo numero"))
    except: 
        print("Ambos parametros deber ser numeros enteros")
    else: 
        print(sumarNumero(a, b))

