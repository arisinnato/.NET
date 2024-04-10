public class Inventario
{
    public int Id { get; set; }
    public int EspacioDisponible { get; set; }
    public List<Objeto> Objetos { get; set; }
    public int PesoTotal { get; set; }
}