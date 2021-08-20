using BusinessAcessLayer.Interface;
using BusinessAcessLayer.Model;
using Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer.Repositorio
{
    public  class RespositorioCliente : IRepositorioCliente
    {
   

        public void EliminiarCliente(int id)
        {
            using (var Db = new DataContextFinandina())
            {
                var Eliminar = Db.Cliente.Find(id);
                Db.Cliente.Remove(Eliminar);
            }
        }

        public ModelCliente ObtenerClienteId(int id)
        {
            using (var Db = new DataContextFinandina())
            {
                return MapearAAplicacionCliente(Db.Cliente.Find(id));
            }
        }

        public ModelCliente ObtenerClienteNom(string Nom_Cliente)
        {
            throw new NotImplementedException();
        }

        public List<ModelCliente> ObtenerTodosCliente()
        {
            using (var Db = new DataContextFinandina())
            {
                return Db.Cliente.Select(MapearAAplicacionCliente).ToList();
            }
        }



        private ModelCliente MapearAAplicacionCliente(Cliente Tabla)
        {
            return new ModelCliente()
            {

             Id  = Tabla.Id,
             Numero_Identificacion  = Tabla.Numero_Identificacion,
             Nombre  = Tabla.Nombre ,
             Cuidad = Tabla.Cuidad,
             Telefono = Tabla.Telefono

            };
        }
    }
}
