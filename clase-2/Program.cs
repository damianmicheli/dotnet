/* 
 * Ejercicio 1
 * 
 * Variables 
 * 
 * Escribe un programa que reciba datos de una persona y genera un mensaje,
 * usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad,
 * sabe programar, etc. 
 */

string? nombre;
string? apellido;
int edad;
bool sabeProgramar;

Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine();

Console.Write("Ingrese su apellido: ");
apellido = Console.ReadLine();

Console.Write("Ingrese su edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Sabe programar?(s/n): ");
sabeProgramar = Console.ReadLine() == "s";

Console.WriteLine($"\nTe llamas {nombre} {apellido}, tenes {edad} años " +
    $"y {(sabeProgramar?"":"no ")}sabes programar.");


/* 
 * Ejercicio 2
 * 
 * Tipos 
 * 
 * Usando los tipos de variables más adecuados, describe los objetos siguientes:
 * 
 * Coche: puertas, ruedas, marca, ITV vigente
 * Mesa: peso, largo, material, color
 * 
 * Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del
 * ejercicio es almacenar los datos en los tipos más adecuados.
 */

// Coche

int puertas = 5;
int ruedas = 4;
string marca = "BMW";
bool itvVigente = true;

Console.WriteLine($"\nUn auto marca {marca} con {puertas} puertas y {ruedas} ruedas. " +
    $"La ITV {(itvVigente?"":"no ")}se encuentra vigente.");

// Mesa

float peso = 5.6f;
float largo = 1.6f;
string material = "roble";
string color = "marrón";

Console.WriteLine($"\nLa mesa de {material} pesa {peso} Kgs., mide {largo} mts. de " +
    $"largo y es de color {color}.");


/* 
 * Ejercicio 3
 * 
 * Operadores 
 * 
 * Determina los operadores para verificar las siguientes condiciones:
 * Un número es mayor o igual a 18
 * Un char es ‘a’
 * Se cumplen dos conciones a la vez (ambas verdaderas)
 * Se cumple una de dos condiciones a la vez (una true y otra false)
 * 
 * Nota: puedes escribir estos datos por consola si prefieres verlos. 
 * La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 */

int numero;
char caracter;

Console.Write("\nIngrese un numero: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese un caracter: ");
caracter = Convert.ToChar(Console.Read());

Console.WriteLine($"\nEl numero ingresado '{numero}' es" +
    $" {(numero >= 18 ? "mayor o igual" : "menor")} a 18.");

Console.WriteLine($"\nEl caracter ingresado '{caracter}' es " +
    $"{(caracter == 'a' ? "igual a" : "distinto de")} 'a'.");

Console.WriteLine("\nProbando AND:");

if (numero >= 18 && caracter == 'a')
{
    Console.WriteLine("Las dos condiciones anteriores eran verdaderas.");
}
else
{
    Console.WriteLine("Al menos una de las condiciones anteriores era falsa.");
}

Console.WriteLine("\nProbando OR:");

if (numero >= 18 || caracter == 'a')
{
    Console.WriteLine("Al menos una de las condiciones anteriores era verdadera.");
}
else
{
    Console.WriteLine("Las dos condiciones anteriores eran falsas.");
}