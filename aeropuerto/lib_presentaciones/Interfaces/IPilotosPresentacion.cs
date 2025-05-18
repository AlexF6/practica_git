using lib_dominio.Entidades;

namespace lib_presentaciones.Interfaces
{
    public interface IPilotosPresentacion
    {
        Task<List<Pilotos>> Listar();
        Task<List<Pilotos>> PorCodigo(Pilotos? entidad);
        Task<Pilotos?> Guardar(Pilotos? entidad);
        Task<Pilotos?> Modificar(Pilotos? entidad);
        Task<Pilotos?> Borrar(Pilotos? entidad);
    }
}