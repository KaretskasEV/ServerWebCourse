﻿using System.Collections.Generic;

namespace Academits.Karetskas.Migrations.Model
{
    public class Supplier
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
