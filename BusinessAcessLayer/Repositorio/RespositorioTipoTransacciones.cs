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
  public   class RespositorioTipoTransacciones : IRepositorioTipoTransacciones
    {
      
    

        public ModelTipoTransacciones ObtenerTipoTransaccionesId(int id)
        {
            using (var Db = new DataContextFinandina())
            {
                return MapearAAplicacionTipoTransacciones(Db.TipoTransacciones.Find(id));
            }
        }

        public ModelTipoTransacciones ObtenerTipoTransaccionesNom(string Nom_TipoTransacciones)
        {
            throw new NotImplementedException();
        }

        public List<ModelTipoTransacciones> ObtenerTodosTipoTransacciones()
        {
            using (var Db = new DataContextFinandina())
            {
                return Db.TipoTransacciones.Select(MapearAAplicacionTipoTransacciones).ToList();
            }
        }


   

        private ModelTipoTransacciones MapearAAplicacionTipoTransacciones(TipoTransacciones Tabla)
        {
            return new ModelTipoTransacciones()
            {

                Id = Tabla.Id,
                Nombre = Tabla.Nombre
             
            };
        }
    }
}
