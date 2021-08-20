using BusinessAcessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer.Interface
{
    public interface IRepositorioTipoTransacciones
    {
   
    
 
        List<ModelTipoTransacciones> ObtenerTodosTipoTransacciones();
        ModelTipoTransacciones ObtenerTipoTransaccionesId(int id);
        ModelTipoTransacciones ObtenerTipoTransaccionesNom(string Nom_TipoTransacciones);

    }
}
