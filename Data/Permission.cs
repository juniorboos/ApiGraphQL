using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGraphQL.Data
{
    [Table("permission")]
    public class Permission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Desc { get; set; }
    }
}