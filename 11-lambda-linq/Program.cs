using System.Diagnostics;

//Expresiones lambda en una función
Func<int, int> cuadrado = x => x * x;
Func<int, bool> esPar = n => n % 2 == 0;

//usamos las expresiones lambda
int numero = 6;

int elCuadrado = cuadrado(numero);
Debug.WriteLine($"El dobel de {numero } es {elCuadrado}");

bool Par = esPar(numero );
Debug.WriteLine($"¿El número {numero} es par?:  {Par}");

var lista  = new List<int> {2,8,15,20,25 };
var resultado = lista.FirstOrDefault(x => x > 9);
Debug.WriteLine($"En la lista {string.Join(", ", lista)} el número mas grande que 9 es? {resultado}");

//LINQ es una forma de consulta colecciones como listas, arrays...

var numeros = new List<int> { 1, 2, 3, 4, 5 };

//where: filtara elementos que cumplen una condición
var mayoresQueTres = numeros.Where(n => n > 3);
foreach (var num in mayoresQueTres)
{
    Debug.WriteLine(num); // Imprime 4 y 5
}

//Select: transformar cada elemento de la colección
var cuadrados = numeros.Select(n => n * n);
foreach (var cuad in cuadrados)
{
    Debug.WriteLine(cuad); // Imprime 1, 4, 9, 16, 25
}


//FirstOrDefault: Devuelve el primer elemento que cumpla una condición o null si no hay ninguno
var primerPar = numeros.FirstOrDefault(n => n % 2 == 0);
var primerMultiplo11 = numeros.FirstOrDefault(n => n % 11 == 0);

Debug.WriteLine(primerPar); // Imprime 2
Debug.WriteLine(primerMultiplo11); // Imprime 0
