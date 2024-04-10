public class Enemigo
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public int NivelAmenaza { get; set; }
    public string Recompensa { get; set; }
    public List<String> Habilidades { get; set; }

    public int salud {get; set;}
}