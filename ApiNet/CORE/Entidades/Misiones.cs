namespace CORE.Entidades;

public class Misiones
{
    public int id {get; set;}
    public string Nombre { get; set; }
    public List<string> Objetivos { get; set; }
    public int Recompensas { get; set; }
    public string Estado { get; set; }
}

