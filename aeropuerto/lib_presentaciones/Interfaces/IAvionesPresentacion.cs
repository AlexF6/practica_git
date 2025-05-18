using lib_dominio.Entidades;

namespace lib_presentaciones.Interfaces
{
    public interface IAvionesPresentacion
    {
        Task<List<Aviones>> Listar();
        Task<List<Aviones>> PorCodigo(Aviones? entidad);
        Task<Aviones?> Guardar(Aviones? entidad);
        Task<Aviones?> Modificar(Aviones? entidad);
        Task<Aviones?> Borrar(Aviones? entidad);
    }
}