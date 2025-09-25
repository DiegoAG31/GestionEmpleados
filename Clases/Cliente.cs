public class Cliente : Persona
{
    public string Email { get; set; }
    public string Telefono { get; set; }

    // Sobrescribe MostrarInformacion
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre completo: {Nombre} {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Teléfono: {Telefono}");
    }
}