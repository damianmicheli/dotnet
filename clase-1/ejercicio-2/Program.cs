/* Ejercicio 2

Escribe un programa que tome la hora y la escriba por pantalla. */

string hora = DateTime.Now.ToShortTimeString();
Console.WriteLine("Hola, son las " + hora);