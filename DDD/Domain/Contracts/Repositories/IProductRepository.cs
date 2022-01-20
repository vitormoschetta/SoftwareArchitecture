using System;
using System.Collections.Generic;
using Domain.Models;

namespace Domain.Contracts.Repositories
{
    public interface IProductRepository
    {
        void Add(Product item);
        void Update(Product item);
        Product Get(Guid id);
        IEnumerable<Product> GetAll();
    }
}