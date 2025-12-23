def es_numEntero(num1):       # La función en general a usar para saber si
    if num1 == "":            # El número es un número entero o no (validarlo)
        return False            # Si no tiene nada el input pues da false (no es entero)

    if num1[0] == "-":            # Si lleva guión medio o menos por ser negativo
        num1 = num1[1:]         # Se omite el guión para después validar el número

    for c in num1:                
        if c < "0" or c > "9":      # Se checa que número este en tre 0 y 9
            return False          # Devuelve false si no
    return True 

def sumarNumeros(a, b):                 # Ahora esta es a función encargada de hacer la suma de los números
    if type(a) != int or type(b) != int:    # Verifica con el != que ambos sean int
        return "Ambos parámetros deben ser números enteros." # La confirmación como si fuera print
    return "El resultado de la suma es: " + str(a + b) + " SW" # Parsea de int a string el resultado de la suma

a = input("Ingresa el primer número entero: ") #El input para a 
b = input("Ingresa el segundo número entero: ")# El input para b

if es_numEntero(a) and es_numEntero(b): # Checa que ambos num sean enteros después de los inputs
    a = int(a)
    b = int(b)
    print(sumarNumeros(a, b)) # el print de la suma
else:
    print("Ambos parámetros deben ser números enteros.") # El caso del else por si no son int los números

# Solo como pequeña aclaración, el isdigit no se usó por los número negativos, preferí omitirlo (Se explica en Readme).