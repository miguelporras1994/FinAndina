using BusinessAcessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer.Interface
{
    public interface IRepositorioCliente
    {

        void EliminiarCliente(int id);
   
        List<ModelCliente> ObtenerTodosCliente();
        ModelCliente ObtenerClienteId(int id);
        ModelCliente ObtenerClienteNom(string Nom_Cliente);

    }
}
