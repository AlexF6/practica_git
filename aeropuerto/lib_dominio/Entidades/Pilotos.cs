using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace lib_dominio.Entidades
{
    public  class Pilotos
    {
        [Key]public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public decimal Pago { get; set; }
    }
}
