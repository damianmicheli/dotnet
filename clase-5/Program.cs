/*
 * Ejercicio 1 - If
 * 
 * Escribe un programa que:
 * 
 * Pida datos a un cliente: Nombre, email, cupón
 * 
 * Determine si un cliente tiene un cupon descuento
 * 
 * Muestre un precio rebajado en función del descuento
 * 
 * Muestre el precio de un producto sin descuento si no hay cupón
 * 
 * Nota: puedes poner un precio fijo de un producto o uno variable.
 */

Console.Write("Ingrese Nombre: ");
string? nombre = Console.ReadLine();

Console.Write("Ingrese Email: ");
string? email = Console.ReadLine();

Console.Write("Tiene cupon? (s/n): ");
bool cupon = Console.ReadLine() == "s";

if (cupon)
{
    Console.WriteLine("Tenes cupon! que suerte! El precio rebajado es 3 euros.");
}
else
{
    Console.WriteLine("No tenes cupon! que mala suerte! El precio normal es 3000 euros.");
}



/*
 * Ejercicio 2 - Switch
 * 
 * Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta 
 * la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 
 * o a, b, c. Presenta el resultado en consola.
 * 
 * Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
 */

Console.Write(@"
 Lenguajes:
 ---------
 1. C#
 2. Java
 3. C++
    
 Elija una de las opciones: ");
string? seleccion = Console.ReadLine();

Console.Write("\n Que bien! Elegiste ");

switch (seleccion)
{
    case "1":
        Console.WriteLine("C#. Hola, mundo.");
        break;
    case "2":
        Console.WriteLine("Java");
        break;
    case "3":
        Console.WriteLine("C++");
        break;
    default:
        Console.WriteLine("el camino de la violencia.");
        break;
}