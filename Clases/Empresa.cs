public class Empresa
{
    public List<Empleado> ListaEmpleados { get; private set; }
    public List<Cliente> ListaClientes { get; private set; }

    public Empresa()
    {
        ListaEmpleados = new List<Empleado>();
        ListaClientes = new List<Cliente>();
    }

    // Métodos para empleados
    public void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }

    public void EliminarEmpleado(string nombre, string apellido)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e =>
            e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
            e.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));
        if (empleado != null)
        {
            ListaEmpleados.Remove(empleado);
            Console.WriteLine($"Empleado {nombre} {apellido} eliminado.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public void MostrarTodosLosEmpleados()
    {
        if (!ListaEmpleados.Any())
        {
            Console.WriteLine("No hay empleados registros.");
            return;
        }
        foreach (var empleado in ListaEmpleados)
        {
            empleado.MostrarInformacion();
            Console.WriteLine("---------------------");
        }
    }

    // Métodos para clientes
    public void AgregarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
    }

    public void EliminarCliente(string nombre, string apellido)
    {
        var cliente = ListaClientes.FirstOrDefault(c =>
            c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
            c.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));
        if (cliente != null)
        {
            ListaClientes.Remove(cliente);
            Console.WriteLine($"Cliente {nombre} {apellido} eliminado.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    public void MostrarTodosLosClientes()
    {
        if (!ListaClientes.Any())
        {
            Console.WriteLine("No hay clientes registrados.");
            return;
        }
        foreach (var cliente in ListaClientes)
        {
            cliente.MostrarInformacion();
            Console.WriteLine("---------------------");
        }
    }   
}
