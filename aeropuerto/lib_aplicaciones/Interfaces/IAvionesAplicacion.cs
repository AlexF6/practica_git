using lib_dominio.Entidades;

namespace lib_aplicaciones.Interfaces
{
    public interface IAvionesAplicacion
    {
        void Configurar(string StringConexion);
        List<Aviones> PorCodigo(Aviones? entidad);
        List<Aviones> Listar();
        Aviones? Guardar(Aviones? entidad);
        Aviones? Modificar(Aviones? entidad);
        Aviones? Borrar(Aviones? entidad);
    }
}