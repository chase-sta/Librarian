using System.ComponentModel.DataAnnotations;

namespace Librarian.Models
{
    public class Reader
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [EmailAddressAttribute]
        public string Email { get; set; }

        public int BooksBorrowed { get; set; } = 0;
    }
}
