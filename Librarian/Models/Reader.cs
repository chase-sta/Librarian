﻿namespace Librarian.Models
{
    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int BooksBorrowed { get; set; } = 0;
    }
}
