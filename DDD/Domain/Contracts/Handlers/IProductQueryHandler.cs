using System;
using System.Collections.Generic;
using Domain.Models;

namespace Domain.Contracts.Handlers
{
    public interface IProductQueryHandler
    {
        Product Handle(Guid id);
        IEnumerable<Product> Handle();
    }
}