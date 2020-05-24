using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGraphQL.Data
{
    [Table("category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public string Characteristics { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; } = new List<ProductCategory>();
    }
}