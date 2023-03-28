using System;
using System.ComponentModel.DataAnnotations;

namespace Librarian.Models
{
	public class Books
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Genre { get; set; }


        public bool IsAvailble { get; set; }

        public string Description { get; set; }
        
    }
}

