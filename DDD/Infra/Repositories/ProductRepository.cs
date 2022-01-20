using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Contracts.Repositories;
using Domain.Models;

namespace Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IList<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public void Add(Product item)
        {
            _products.Add(item);
        }

        public void Update(Product item)
        {
            var product = _products.FirstOrDefault(x => x.Id == item.Id);

            if (product != null)
            {
                product.Update(item.Name, item.Price);
            }
        }

        public Product Get(Guid id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

    }
}