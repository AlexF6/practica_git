using lib_dominio.Entidades;

namespace mst_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Pilotos? Pilotos()
        {
            var entidad = new Pilotos();
            entidad.Cedula = "1";
            entidad.Nombre = "Juan";
            entidad.Pago = 1000.0m;
            return entidad;
        }

        public static Aviones? Aviones()
        {
            var entidad = new Aviones();
            entidad.Codigo = "001";
            entidad.Modelo = "2018";
            entidad.FechaCompra = DateTime.Now;
            entidad.Piloto = 1;
            return entidad;
        }
    }
}
