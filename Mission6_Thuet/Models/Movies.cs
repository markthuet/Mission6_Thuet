using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// Creator: Mark Thuet
// Description: This is a website to show off Joel Hilton and his movie collection. Super dope
namespace Mission6_Thuet.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }


        [ForeignKey("Category")]
      
        public int? CategoryId { get; set; }
        
        public Category? Categories { get; set; }


        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "The year must be greater than or equal to 1888")]
        public int Year { get; set; }

       
        public string? Director { get; set; }

 
        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited is required.")]
        public int Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "CopiedToPlex is required.")]
        public int CopiedToPlex { get; set; }

        public string? Notes { get; set; }
    }
}