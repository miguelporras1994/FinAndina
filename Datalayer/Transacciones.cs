namespace Datalayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transacciones
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public int? Tipo_Transacciones { get; set; }

        public double? Monto { get; set; }

        public double? Total { get; set; }

        public int? Id_Origen { get; set; }

        public int? Id_Destino { get; set; }

        public int? Saldo_inicial { get; set; }

        public int? Saldo_Total { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public virtual Cuenta Cuenta1 { get; set; }

        public virtual TipoTransacciones TipoTransacciones { get; set; }
    }
}
