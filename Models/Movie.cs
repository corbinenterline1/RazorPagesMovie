using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        // Required by the database for the primary key.
        public int ID { get; set; }
        // Title of the movie, default empty string.
        public string Title { get; set; } = string.Empty;
        // 
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
