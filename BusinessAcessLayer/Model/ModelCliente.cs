using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer.Model
{
   public class ModelCliente
    {
        public int Id { get; set; }

        public int? Numero_Identificacion { get; set; }

   
        public string Nombre { get; set; }

    
        public string Cuidad { get; set; }


        public string Telefono { get; set; }

    }
}
