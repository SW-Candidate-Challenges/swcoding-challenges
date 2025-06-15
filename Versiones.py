def versionesString(msj):
    '''
    Funcion que recibe un string almaceno la clave y el valor en un diccionario de datos clave:valor
    Valida si los valores son validos, en caso de no serlo -> Error
    En caso de ser validos retorna -> Success 
    '''
    version = 0.0
    resultado = ""                              #Varialbes necesarias para el funcionamiento: version y resultado para el mensaje a retornar, datosUsuario sera un dict{} 
    datosUsuario = {}
    contador = 0                                #Contador para contabilizar cuantos datos clave:valor tenemos y posteriormente realizar validaciones para saber si es Error o Success
    #Preprocesamos el texto recibido.
    texto = tuple(msj.split("|"))               #partimos el texto por cada | y lo almacenamos en un [list] para procesarlo  
    for x in range(len(texto)):                 #Iteramos cada elemento de la lista para posteriormente partirlo de nuevo por sus :
        clave,valor = texto[x].split(":")       #Dividimos el texto por sus : y almacenamos el lado izq en clave y el lado der en valor
        datosUsuario[clave] = valor             #Lo insertamos dentro de datosUsuario[clave] = valor para hacer que el acceder a los indices sea O(1)
        contador +=1
    #Validaciones de clave : valor
    if "name" in datosUsuario:
        if len(datosUsuario["name"])>=5: contador-=1
        else: contador=contador 
    if "age" in datosUsuario:
        if int(datosUsuario["age"])>18: contador-=1
        else: contador=contador
    if "state" in datosUsuario:
        if len(datosUsuario["state"])>=5: contador-=1
        else: contador=contador
    if "zipcode" in datosUsuario:
        if len(datosUsuario["zipcode"])>=5: contador-=1
        else: contador=contador
    if "status" in datosUsuario:
        if datosUsuario["status"].lower() == "casado" or "soltero": contador-=1
        else: contador=contador
    #Asignaciones de version y resultado
    if "zipcode" in datosUsuario and contador == 0: 
        version = 4.0
        resultado = "Success"
    elif "status" in datosUsuario and contador == 0:
        version = 4.0
        resultado = "Success"
    elif "zipcode" and "status" not in datosUsuario and contador == 0:
        version = 3.3
        resultado = "Success"
    elif "zipcode" in datosUsuario and contador != 0: 
        version = 4.0
        resultado = "Error"
    elif "status" in datosUsuario and contador != 0:
        version = 4.0
        resultado = "Error"
    elif "zipcode" and "status" not in datosUsuario and contador != 0:
        version = 3.3
        resultado = "Error"

    mensaje = print(f"Version {version}|{resultado}")
    return mensaje


versionesString("name:Andrea|age:29|state:Jalisco|zipcode:44100|status:Soltero")

versionesString("name:PedroL|age:22|state:Nayarit")

versionesString("name:Ana|age:19|state:Yucatán|zipcode:1234|status:Casado")

versionesString("name:Roberto|age:17|state:Sonora|status:Soltero")

versionesString("name:Elisa|age:30|state:DF|zipcode:99999|status:divorciado")