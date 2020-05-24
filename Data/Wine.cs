using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGraphQL.Data
{
    [Table("wine")]
    public class Wine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Batch { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }

        [Required]
        public DateTime ShelfLife { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; }

        public int TaskId { get; set; }

        [Required]
        public Task Task { get; set; }

        public ICollection<StockWine> StockWines { get; } = new List<StockWine>();
    }
}