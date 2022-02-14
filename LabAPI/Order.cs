namespace LabAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        public int? ProdID { get; set; }

        public string Title { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}
