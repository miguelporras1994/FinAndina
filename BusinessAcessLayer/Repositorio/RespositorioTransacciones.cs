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
   public  class RespositorioTransacciones : IRepositorioTransacciones
    {
        public void AgregarTransacciones(ModelTransacciones model)
        {
            using (var Db = new  DataContextFinandina())
            {
                Db.Transacciones.Add(MapearTransaccionesDataBase(model));
            }
        }

        public void EditarTransacciones(ModelTransacciones Tabla)
        {
            using (var Db = new  DataContextFinandina())
            {
                var Editar = Db.Transacciones.Find(Tabla.Id);

                Editar.Id = Tabla.Id;

                Editar.Fecha = Tabla.Fecha;

                Editar.Tipo_Transacciones = Tabla.Tipo_Transacciones;

                Editar.Monto = Tabla.Monto;

                Editar.Total = Tabla.Total;

      Editar.Id_Origen = Tabla.Id_Origen;

        Editar.Id_Destino = Tabla.Id_Destino;

        Editar.Saldo_inicial = Tabla.Saldo_inicial;

        Editar.Saldo_Total = Tabla.Saldo_Total;

                Db.SaveChanges();

            }
        }

        public void EliminiarTransacciones(int id)
        {
            using (var Db = new  DataContextFinandina())
            {
                var Eliminar = Db.Transacciones.Find(id);
                Db.Transacciones.Remove(Eliminar);
            }
        }

        public ModelTransacciones ObtenerTransaccionesId(int id)
        {
            using (var Db = new  DataContextFinandina())
            {
                return MapearAAplicacionTransacciones(Db.Transacciones.Find(id));
            }
        }

        public List<ModelTransacciones> ObtenerTodosTransacciones()
        {
            using (var Db = new  DataContextFinandina())
            {
                return Db.Transacciones.Select(MapearAAplicacionTransacciones).ToList();
            }
        }


        private Transacciones MapearTransaccionesDataBase(ModelTransacciones Tabla)
        {
            return new Transacciones()
            {
  Id  = Tabla.Id,

         Fecha  = Tabla.Fecha, 

       Tipo_Transacciones  = Tabla.Tipo_Transacciones,

       Monto  =  Tabla.Monto,

      Total  =   Tabla.Total,

       Id_Origen  = Tabla.Id_Origen,

         Id_Destino  = Tabla.Id_Destino,

        Saldo_inicial  = Tabla.Saldo_inicial,

        Saldo_Total = Tabla.Saldo_Total



            };
        }

        private ModelTransacciones MapearAAplicacionTransacciones(Transacciones Tabla)
        {
            return new ModelTransacciones()
            {

            Id  = Tabla.Id,

         Fecha  = Tabla.Fecha, 

       Tipo_Transacciones  = Tabla.Tipo_Transacciones,

       Monto  =  Tabla.Monto,

      Total  =   Tabla.Total,

       Id_Origen  = Tabla.Id_Origen,

         Id_Destino  = Tabla.Id_Destino,

        Saldo_inicial  = Tabla.Saldo_inicial,

        Saldo_Total = Tabla.Saldo_Total
            };
        }

        public ModelTransacciones ObtenerTransaccionesNom(string Nom_Transacciones)
        {
            throw new NotImplementedException();
        }
    }
}
