using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models 
{
    public class Movie
    {
        public int ID { get; set; } // Required by DB for primary key
        public string Title { get; set; }

        [DataType(DataType.Date)] // Specifies type of data (Date)
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}