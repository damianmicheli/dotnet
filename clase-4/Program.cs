/*
 *
 * Ejercicio 1 - While
 *
 * Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe
 *   por consola. Es decir, un programa que presente para el 1:
 *
 * 1 x 1 = 1
 * 1 x 2 = 2
 * …
 * 1 x 10 = 10
 */

const int INICIO = 1;
const int FIN = 10;
bool convertido;
int numero;

Console.WriteLine("\n EJERCICIO 1 - WHILE\n\n");

do{
    Console.Write(" Ingrese un número entero: ");
    convertido = int.TryParse(Console.ReadLine(), out numero);
} while (!convertido);


Console.WriteLine("\n Tabla de multiplicar");

for(int i = INICIO; i <= FIN; i++)
{
    Console.WriteLine($" {numero} x {i} = {numero * i}");
}


/*
 * Ejercicio 2 - Do while
 * 
 * Escribe un programa que realice estos pasos:
 * 
 *  - Reciba al menos un número por consola
 * 
 *  - Determine si el número es positivo o negativo
 * 
 *  - Presente un contador para cada tipo (positivo y negativo).
 * 
 * Nota: el cero se puede abordar en una clase adicional ya que no es ni
 *     positivo ni negativo. Tienes completa libertad para elegir el formato
 *     de la salida.
 */

Console.WriteLine("\n EJERCICIO 2 - DO WHILE");

int otroNumero;
int contPos = 0;
int contNeg = 0;
int contCero = 0;
string resultado;
string? continuar;

do
{
    
    do {
        Console.Write("\n Ingrese un numero entero (positivo o negativo): ");
        convertido = int.TryParse(Console.ReadLine(), out otroNumero);
    } while (!convertido);
    

    if (otroNumero == 0) 
    {
        resultado = "El cero no es ni positivo ni negativo.";
        contCero++;
    }
    else if (otroNumero > 0)
    {
        resultado = $"El numero {otroNumero} es positivo.";
        contPos++;
    }
    else
    {
        resultado = $"El numero {otroNumero} es negativo.";
        contNeg++;
    }

    Console.Write(@$"
 {resultado}

 Total de números:
 ----------------
 Números positivos: {contPos}
 Números negativos: {contNeg}
 Cantidad de ceros: {contCero}

 Desea continuar? (s/n): ");

    continuar = Console.ReadLine();

} while ( continuar == "s" || continuar == "S");

Console.WriteLine("\n Gracias!");

/*
 *     Ejercicio 3 - For
 * 
 * Escribe un programa que realice estos pasos:
 * 
 *  - Reciba 3 datos:
 * 
 *      - ancho
 * 
 *      - alto
 * 
 *      - relleno o no
 * 
 *  - Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las
 * dimensiones introducidas y use el tercer dato para discernir si el rectángulo 
 * está relleno (tiene más * dentro) o no.
 * 
 *  - En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
 * 
 * Reto: Extiende el programa anterior para recibir otro número que sea el número de
 * cuadrados o rectángulos que se deben dibujar en la pantalla.Ejemplos:
 * 
 *  - Input: 2,2,2, relleno = true
 * 
 *    Output:
 * 
 *    ** **
 *    
 *    ** **
 *    
 *  - Input: 3, 4, 1, relleno = false
 *    
 *    Output:
 *    
 *    ***
 *    
 *    * *
 *    
 *    * *
 *    
 *    ***
 */

Console.WriteLine("\n EJERCICIO 3 - FOR");

int ancho;
int alto;
int cantidad;
bool relleno;

do
{
    Console.Write("\n Ingrese valor de ancho: ");
    ancho = Convert.ToInt32(Console.ReadLine());

    Console.Write("\n Ingrese valor de alto: ");
    alto = Convert.ToInt32(Console.ReadLine());

    Console.Write("\n Relleno? (s/n): ");
    relleno = Console.ReadLine() == "s";

    Console.Write("\n Ingrese cantidad: ");
    cantidad = Convert.ToInt32(Console.ReadLine());
    Console.Write("\n");

    for (int k = 1; k <= cantidad; k++)
    {
        for (int i = 1; i <= alto; i++)
        {
            for (int j = 1; j <= ancho; j++)
            {
                if ((relleno) || ((i == 1) || (i == alto)) || ((j == 1) || (j == ancho)))
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.Write("\n");
        }
        Console.Write("\n\n");

    }

    Console.Write("\n Desea continuar? (s/n): ");
    continuar = Console.ReadLine();

} while (continuar == "s" || continuar == "S");

Console.WriteLine("\n Gracias!");
