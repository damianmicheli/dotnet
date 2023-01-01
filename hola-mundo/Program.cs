Console.Write("Ingresa tu nombre: ");
string? nombre = Console.ReadLine();

int edad = 0;

while (edad == 0)
{
    Console.Write("Ingresa tu edad: ");
    try
    {
        edad = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException e)
    {
        Console.WriteLine("Sos medi@ pelotud@! No sabes tu edad?");
    }
}
Console.Write("Ingresa tu ciudad: ");
string? ciudad = Console.ReadLine();

string hora = DateTime.Now.ToShortTimeString();

Console.WriteLine("Son las " + hora);

Console.WriteLine($"Hola, {nombre}. Tenes {edad} años. Vivis en {ciudad}.");

