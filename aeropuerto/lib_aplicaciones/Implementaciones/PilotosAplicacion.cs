using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class PilotosAplicacion : Interfaces.IPilotosAplicacion
    {
        private IConexion? IConexion = null;

        public PilotosAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Pilotos? Borrar(Pilotos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            this.IConexion!.Pilotos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Pilotos? Guardar(Pilotos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Calculos

            this.IConexion!.Pilotos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Pilotos> Listar()
        {
            return this.IConexion!.Pilotos!.Take(20).ToList();
        }

        //public List<Pilotos> PorCodigo(Pilotos? entidad)
        //{
        //    return this.IConexion!.Pilotos!
        //        .Where(x => x.Codigo!.Contains(entidad!.Codigo!))
        //        .ToList();
        //}

        public Pilotos? Modificar(Pilotos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            var entry = this.IConexion!.Entry<Pilotos>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
