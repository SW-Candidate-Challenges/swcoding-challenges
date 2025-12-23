def validar_versiones(texto):
    cadena = {}   # Aquí se guardan los datos

    partes = texto.split("|")  # Separa las partes del texto que tengan: |

    for posicion in partes:
        if ":" in posicion:
            id, valor = posicion.split(":")  # Separa todo lo que tenga : en el texto
            cadena[id] = valor

    if "zipcode" in cadena or "status" in cadena:   # Si el texto dice zipcode o status (Así está escrito en el txt)
        version = "4.0"                              # Entonces la versión será 4.0
    else:
        version = "3.3"                              # Si no está escrito, la versión será 3.3

    valido = True                               # Variable para validar los datos en general  

    if "name" in cadena:                         # Verifica que exista name
        if len(cadena["name"]) < 5:              # Revisa que tenga al menos 5 caracteres
            valido = False
    else:
        valido = False

    if "age" in cadena:                         # Verifica que exista age
        try:
            age = int(cadena["age"])          # Convierte age a número
            if age < 18:                      # Revisa que sea mayor o igual a 18
                valido = False
        except:
            valido = False
    else:
        valido = False

    if "state" in cadena:                    # Verifica que exista state
        if len(cadena["state"]) < 5:                     # Revisa que tenga al menos 5 caracteres
            valido = False
    else:
        valido = False

    if "zipcode" in cadena:                         # Si existe zipcode
        zcode = cadena["zipcode"]
        if len(zcode) != 5:                              # Revisa que tenga exactamente 5 caracteres
            valido = False
        else:
            if not zcode.isdigit():                          # Revisa que solo tenga números
                valido = False

    if "status" in cadena:                            # Si existe status
        s = cadena["status"].lower()                    # Pasa el texto a minúsculas
        if s != "soltero" and s != "casado":                 # Solo acepta soltero o casado
            valido = False

    if valido:                                           # Si todo fue válido
        return "Version " + version + "|Success"
    else:                                                # Si algo falló
        return "Version " + version + "|Error"


entrada = "name:Emanuel|age:22|state:Sinaloa|zipcode:82124|status:Soltero"
print(validar_versiones(entrada))
