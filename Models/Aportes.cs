using System.ComponentModel.DataAnnotations;

public class Aportes{
    [Key]
    public int AporteId { get; set; }

    public DateTime fecha{get; set;} = DateTime.Now;

    public string? Persona{ get; set; }
    public string? Observacion { get; set; }

    public float? Monto { get; set; }
}