Reto #1: Versiones  
Mi misión era hacer lq prueba en cualquier lenguaje de programacion yo decidi tomar C#
El trabajo era revisar una cadena de datos larga, asegurarme de que todo fuera válido (Success o Error), y etiquetarla con la Versión 4.0 o 3.3.

Primero tuve que Poner los Datos en Orden:En lugar de romper la cadena , usé Dictionary.
Usé LINQ para procesar listas rápido y convertí la cadena completa a pares lo pido directamente y me lo da, sin tener que buscarlo.
Usé una bandera, que fue esValidoTotal, que empieza en true (todo bien).
Si al revisar CUALQUIER REGLA (nombre, edad, estado, etc.) encuentro un problema, la bandera se cambia a false.
Una vez que es false, el resultado final será Error.

Se Uso una bandera llamada usaVersion40.Si encontré zipcode o status, prende la bandera.
Si está prendida, el resultado es 4.0. Si no, es 3.3.4.
Junté la Versión con el Resultado (Success o Error) en el formato que se pidió.