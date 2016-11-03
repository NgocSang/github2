namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("report")]
    public partial class report
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string mastercard { get; set; }

        public int? Ammountmastercard { get; set; }

        [StringLength(10)]
        public string debitcard { get; set; }

        public int? Ammountdebitcard { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_transation { get; set; }
    }
}
