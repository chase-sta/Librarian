using System;
using System.ComponentModel.DataAnnotations;

namespace Librarian.Models
{
	public class Book
	{
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the title of the book")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the author of the book")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please enter the genre of the book")]
        public string Genre { get; set; }

        
        //public bool IsAvailble { get; set; }

        //public string Description { get; set; }
        
    }
}

