using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class AvionesAplicacion : IAvionesAplicacion
    {
        private IConexion? IConexion = null;

        public AvionesAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Aviones? Borrar(Aviones? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            this.IConexion!.Aviones!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Aviones? Guardar(Aviones? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Calculos
            return entidad;
        }

        public List<Aviones> Listar()
        {
            return this.IConexion!.Aviones!.Take(20).ToList();
        }

        //public List<Aviones> PorNombre(Aviones? entidad)
        //{
        //    return this.IConexion!.Aviones!
        //        .Where(x => x.Nombre!.Contains(entidad!.Nombre!))
        //        .ToList();
        //}

        public Aviones? Modificar(Aviones? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Calculos

            var entry = this.IConexion!.Entry<Aviones>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
