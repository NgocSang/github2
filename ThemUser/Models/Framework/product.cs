namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        public decimal? price { get; set; }

        [StringLength(30)]
        public string origin { get; set; }

        public int? quantity { get; set; }
    }
}
