# Reto Ejercicio 2 

En este reto veremos la funcion **sumerNumero (a, b)**

-Esta funcion es con la que verficiamos los parametos sean **Enteros**

-Si alguna no esta en este parametros muestra lo siguiente:

    Ambos parametros deben ser numeros enteros

Si ambos son validos, los suma y muestra:

    El resultado de la suma es {suma} SW

## Archivos 
- **reto2.py**: Codigo donde se realiza toda el reto como tal 
- **test.py**: Codigo con pruebas unitarias utilizando pytest
- **ReadmeMilogica.md**: Documentacion 

## Como usar

1. con **reto2.py** en la carpeta de proyecto 
2. puedes probar manualmente en el bash:
    pyton test2.py
3. para ejeucion de pruebas que queda como opcional en el bash:

    pip install pytest - **en caso de no tenerlo**
    pytest -q


## Ejemplo de uso
    bash

    python test.py 
    ingrese el primer numero: 6
    ingrese el segundo numero: 6
    El resultado de la suma es: 12 SW

    bash
    python test.py
    ingrese el primer numero: 6.2
    Ambos parametros deben ser numeros enteros 

## Funcionamiento 

1. Pide 2 entradas por la consola y las convierte a int 
2. si esta conversion falla, nos saltara nuestro mensaje de error 
3. llama s sumarNumero(a, b) donde:
    - Comprueba type(x) si este es entero 
    - Si este pasa hace la suma y devuelve mensae formateado 