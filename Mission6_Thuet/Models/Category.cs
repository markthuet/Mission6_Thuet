using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Thuet.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        
        public int CategoryId { get; set; }

        
        public string CategoryName { get; set; }
    }
}