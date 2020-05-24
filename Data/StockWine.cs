using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGraphQL.Data
{
    [Table("stock_wine")]
    public class StockWine
    {
        [Required]
        public int StockId { get; set; }

        [Required]        
        public Stock Stock { get; set; }

        [Required]
        public int WineId { get; set; }

        [Required]
        public Wine Wine { get; set; }
    }   
}