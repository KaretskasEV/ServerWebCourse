﻿namespace Academits.Karetskas.ShopEf.Model
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; } = new();

        public int ProductId { get; set; }

        public virtual Product Product { get; set; } = new();

        public int Count { get; set; }
    }
}
