using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer.Model
{
    public class ModelTransacciones
    {
        public int Id { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Tipo_Transacciones { get; set; }

        public double? Monto { get; set; }

        public double? Total { get; set; }

        public int? Id_Origen { get; set; }

        public int? Id_Destino { get; set; }

        public int? Saldo_inicial { get; set; }

        public int? Saldo_Total { get; set; }

    }
}
