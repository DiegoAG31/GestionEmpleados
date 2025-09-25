public class Empleado : Persona
{
    public string Posicion { get; set; }
    public decimal Salario { get; set; }

    private decimal CalcularBonificacion()
    {
        return Salario * 0.10m;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre completo: {Nombre} {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Posición: {Posicion}");
        Console.WriteLine($"Salario con bonificación: {Salario + CalcularBonificacion():C}");
    }
}