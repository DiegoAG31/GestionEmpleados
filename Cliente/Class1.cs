public class Cliente : Persona
{
    public string Email { get; set; }
    public string Telefono { get; set; }

    // Sobrescribe MostrarInformacion
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Teléfono: {Telefono}");
    }
}