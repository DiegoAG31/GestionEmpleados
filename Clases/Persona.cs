public abstract class Persona
{
    protected Guid Id { get; private set; }
    protected string Nombre { get; set; }
    protected string Apellido { get; set; }
    protected int Edad { get; set; }

    // Método virtual para que pueda ser sobrescrito
    public abstract void MostrarInformacion();
    public Guid IdPublico => Id;

}