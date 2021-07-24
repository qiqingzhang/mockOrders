namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderArchive")]
    public partial class OrderArchive
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int Page { get; set; }

        [Required]
        [StringLength(500)]
        public string PhotoUrl { get; set; }

        public int SaveNum { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        public int AllPage { get; set; }
    }
}
