﻿namespace Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}
