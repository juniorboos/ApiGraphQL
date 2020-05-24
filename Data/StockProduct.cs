using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGraphQL.Data
{
    [Table("stock_product")]
    public class StockProduct
    {
        [Required]
        public int StockId { get; set; }

        [Required]
        public Stock Stock { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public float MinQantity { get; set; }
    }   
}