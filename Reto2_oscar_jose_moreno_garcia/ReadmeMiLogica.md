Reto #2: Sumasw 

Mi misión era hacer la prueba en cualquier lenguaje de programacion yo decidi tomar C# 
y tenia que hacer que SOLO sume si los dos números que le metes son ENTEROS (int). Si me mandaban un decimal, un texto, un true/false, o cualquier cosa rara,
tiene que decir: "¡Error, no se puede!"

Para que esto funcionara, tuve que poner dos filtros para los tipos de datos equivocados:
Para que no se le ocurriera sumar un entero con un decimal.Usé la palabra clave is para preguntar: "Oye, ¿este dato es un string? ¿Es un float? ¿Es un bool?"
Si identifico que es un texto, un decimal, un booleano o null (vacío), lo mando directo al mensaje de error sin intentar nada más. aqui termino mi primer filtro

Si un dato logra pasar el Filtro 1, es un entero.
Puse todo lo importante en un bloque try. Le digo al programa: "Intenta hacer esto, ¡a ver si puedes!".
Si el programa no puede convertir el dato, lanza un error. Y en lugar de que el programa se rompa, manda el mensaje de error.

Conclusión: Solo los números enteros sobreviven los dos filtros y logran sumarse.