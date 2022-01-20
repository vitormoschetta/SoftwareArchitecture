using System;
using Domain.Contracts.Handlers;
using Domain.Contracts.Repositories;
using Domain.Models;
using Shared;

namespace Domain.Command.Handlers
{
    public class ProductCommandHandler : IProductCommandHandler
    {
        private readonly IProductRepository _repository;

        public ProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public GenericResponse Handle(CreateProductCommand command)
        {
            try
            {
                if (command is null)
                    return new GenericResponse(false, "Argumento inválido");

                command.Validate();

                var product = new Product(command.Name, command.Price);

                _repository.Add(product);

                return new GenericResponse(true, "Produto cadastrado com susceso");
            }
            catch (Exception ex)
            {
                return new GenericResponse(false, ex.Message.ToString());
            }
        }

        public GenericResponse Handle(AddPromotionalProductCommand command)
        {
            try
            {
                if (command is null)
                    return new GenericResponse(false, "Argumento inválido");

                command.Validate();

                var product = _repository.Get(command.Id);

                product.UpdatePromotionPrice(command.Price);

                return new GenericResponse(true, "Preço promocional adiciodo com sucesso");
            }
            catch (Exception ex)
            {
                return new GenericResponse(false, ex.Message.ToString());
            }
        }
    }
}