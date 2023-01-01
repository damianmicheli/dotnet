/* Ejercicio 1
 * 
 *  Crea una estructura de datos para un cliente con estos campos:
 * 
 *  - Nombre completo
 *  - Teléfono
 *  - Dirección
 *  - Email
 *  - Si es nuevo cliente
 *  
 *  Bonus: escribe un método para presentar estos datos desde la estructura al 
 *  hacer Console.WriteLine(...)
 */

Cliente cliente1 = new Cliente("Juan", "Perez", "(33)1234-5678", "Calle Falsa 123",
                                "juanperez@yahoo.com", true);

Console.WriteLine(cliente1);

public struct Cliente
{
    public Cliente(string nombre, string apellido, string telefono, 
                    string direccion, string email, bool nuevoCliente)
    {
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        NuevoCliente = nuevoCliente;
    }

    public string Nombre { get; }
    public string Apellido { get; }
    public string Telefono { get; }
    public string Direccion { get; }
    public string Email { get; }
    public bool NuevoCliente { get; }

    public override string ToString()
    {
        return $"Nombre completo: {Nombre} {Apellido}" +
            $"\nTeléfono: {Telefono}" +
            $"\nDirección: {Direccion}" +
            $"\nE-Mail: {Email}" +
            $"\nCliente nuevo: {(NuevoCliente ? "Si" : "No")}";
    }

}