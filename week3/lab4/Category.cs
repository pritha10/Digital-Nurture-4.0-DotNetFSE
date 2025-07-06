﻿using System.Collections.Generic;

namespace Lab3.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();
    }
}
