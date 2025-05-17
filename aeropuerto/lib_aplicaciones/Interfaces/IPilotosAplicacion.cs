using lib_dominio.Entidades;

namespace lib_aplicaciones.Interfaces
{
    public interface IPilotosAplicacion
    {
        void Configurar(string StringConexion);
        //List<Pilotos> PorCodigo(Pilotos? entidad);
        List<Pilotos> Listar();
        Pilotos? Guardar(Pilotos? entidad);
        Pilotos? Modificar(Pilotos? entidad);
        Pilotos? Borrar(Pilotos? entidad);
    }
}