using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using mst_presentacion.Nucleo;

namespace mst_presentacion.Repositorios
{
    [TestClass]
    public class AvionesPrueba
    {
        private readonly IConexion? iConexion;
        private List<Aviones>? lista;
        private Aviones? entidad;

        public AvionesPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.Aviones!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Aviones()!;

            this.iConexion!.Aviones!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Modelo = "Test 2";

            var entry = this.iConexion!.Entry<Aviones>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Aviones!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}