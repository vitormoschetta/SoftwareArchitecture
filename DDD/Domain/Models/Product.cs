using System;

namespace Domain.Models
{
    public class Product
    {
        public Product(Guid id, string name, decimal? price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product(string name, decimal? price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal? Price { get; private set; }

        public void Update(string name, decimal? price)
        {
            Name = name;
            Price = price;
        }

        public void UpdatePromotionPrice(decimal? price)
        {
            if (price > Price)
                throw new Exception("Preço promocional superior ao preço atual do Produto.");
        }
    }
}