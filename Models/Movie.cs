using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        // Required by the database for the primary key.
        public int ID { get; set; }
        // Title of the movie, default empty string.
        public string Title { get; set; } = string.Empty;
        // DataType attribute that specifies the type of data in the ReleaseDate property.
        // With this attribute, the user isn't required to enter time information in the date field.
        // Only the date is displayed, not time information.
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        // This data annotation enables EF Core to correctly map Price to currency in the database.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
