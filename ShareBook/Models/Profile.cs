﻿namespace ShareBookApi.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<BlogPost> Posts { get; set; } = new();
    }
}
