namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistributionPayDetail")]
    public partial class DistributionPayDetail
    {
        public int Id { get; set; }

        public int PayId { get; set; }

        public int OrderId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOffAmount { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDelete { get; set; }
    }
}
