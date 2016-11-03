namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        [Key]
        [StringLength(10)]
        public string username { get; set; }

        [StringLength(30)]
        public string password { get; set; }
    }
}
