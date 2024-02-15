using System.ComponentModel.DataAnnotations;
// Creator: Mark Thuet
// Description: This is a website to show off Joel Hilton and his movie collection. Super dope
namespace Mission6_Thuet.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool? Edited { get; set; } // Make it nullable
        public string? LentTo { get; set; } // Make it nullable
        public string? Notes { get; set; } //
    }
}



