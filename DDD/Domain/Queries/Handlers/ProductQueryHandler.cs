using System;
using System.Collections.Generic;
using Domain.Contracts.Handlers;
using Domain.Contracts.Repositories;
using Domain.Models;

namespace Domain.Queries.Handlers
{
    /// <summary>
    /// Essa classe não necessariamente precisa existir. A UI poderia acessar o 
    /// repositório diretamente.
    /// Porém, caso os objetos (Models) retornado do banco de dados possuirem informações 
    /// que não desejamos apresentar na UI, então essa classe seria o local ideal 
    /// para o mapeamento dos dados para uma ViewModel.
    /// </summary>
    public class ProductQueryHandler : IProductQueryHandler
    {
        private readonly IProductRepository _repository;

        public ProductQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product Handle(Guid id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Product> Handle()
        {
            return _repository.GetAll();
        }
    }
}