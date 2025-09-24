public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    // Método virtual para que pueda ser sobrescrito
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre completo: {Nombre} {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
    }
}