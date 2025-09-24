public class Empleado : Persona
{
    public string Posicion { get; set; }
    public decimal Salario { get; set; }

    // Método para calcular bonificación
    private decimal CalcularBonificacion()
    {
        return Salario * 0.10m;
    }

    // Sobrescribe MostrarInformacion
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Posición: {Posicion}");
        Console.WriteLine($"Salario con bonificación: {Salario + CalcularBonificacion():C}");
    }
}