using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Aviones
    {
        [Key]
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Modelo { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Piloto { get; set; }
        [ForeignKey("Piloto")] public Pilotos? _Piloto { get; set; }
    }
}
