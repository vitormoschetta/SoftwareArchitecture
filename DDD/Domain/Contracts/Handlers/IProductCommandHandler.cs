using Domain.Command;
using Shared;

namespace Domain.Contracts.Handlers
{
    public interface IProductCommandHandler
    {
        GenericResponse Handle(CreateProductCommand command);
        GenericResponse Handle(AddPromotionalProductCommand command);
    }
}