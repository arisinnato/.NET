namespace CORE.Entidades;

public class Personaje
{
     public int Id { get; set; }
    public string Nombre { get; set; }
    public int Nivel { get; set; }
    public int Salud { get; set; }
    public int Energia { get; set; }
    public int Fuerza { get; set; }
    public int Inteligencia { get; set; }
    public int Agilidad { get; set; }
    public List<Objeto> Inventario { get; set; }
}
