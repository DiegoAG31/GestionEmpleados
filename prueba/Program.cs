using System;
using GestionDeEmpleados;

class Program
{
    static void Main()
    {
        Empleado empleado = new Empleado("Juan", "Pérez", "12345", 30, "Desarrollador", 2500);
        empleado.MostrarInformacion();
    }
}