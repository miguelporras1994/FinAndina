using BusinessAcessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer.Interface
{
   public interface IRepositorioTransacciones
    {
        void AgregarTransacciones(ModelTransacciones model);
        void EliminiarTransacciones(int id);
        void EditarTransacciones(ModelTransacciones model);
        List<ModelTransacciones> ObtenerTodosTransacciones();
        ModelTransacciones ObtenerTransaccionesId(int id);
        ModelTransacciones ObtenerTransaccionesNom(string Nom_Transacciones);
    }
}
