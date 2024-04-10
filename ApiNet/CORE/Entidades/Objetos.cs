public class Objeto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public TipoObjeto Tipo { get; set; }
    public int Valor { get; set; }
    public UbicacionObjeto Ubicacion { get; set; }
}

public enum TipoObjeto
{
    Arma,
    Armadura,
    Consumible,
    Otro
}

public enum UbicacionObjeto
{
    Inventario,
    Tienda,
    Recompensa
}