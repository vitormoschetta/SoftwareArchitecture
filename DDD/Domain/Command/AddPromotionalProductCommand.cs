using System;

namespace Domain.Command
{
    public class AddPromotionalProductCommand :  ProductCommandBase
    {
        public Guid Id { get; set; }
    }
}