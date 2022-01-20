using Domain.Command;
using Domain.Command.Handlers;
using Domain.Contracts.Handlers;
using Infra.Repositories;
using Xunit;

namespace Tests.Handlers
{
    public class ProductCommandHandlerTest
    {
        private readonly IProductCommandHandler _handler;

        public ProductCommandHandlerTest()
        {
            _handler = new ProductCommandHandler(new ProductRepository());
        }

        [Fact]
        public void When_Create_Product_Runs_Without_Errors_Response_Success_Is_True()
        {
            var command = new CreateProductCommand();
            command.Name = "Product XPTO";
            command.Price = 9.99m;

            var response = _handler.Handle(command);

            Assert.True(response.Success, response.Message);
        }

        [Fact]
        public void When_trying_to_register_a_product_with_a_name_of_less_than_five_characters_it_returns_an_error()
        {
            var command = new CreateProductCommand();
            command.Name = "Pro";
            command.Price = 9.99m;

            var response = _handler.Handle(command);

            Assert.False(response.Success, response.Message);
        }

        [Fact]
        public void When_trying_to_register_a_product_with_a_null_name_it_returns_an_error()
        {
            var command = new CreateProductCommand();
            command.Name = null;
            command.Price = 9.99m;

            var response = _handler.Handle(command);

            Assert.False(response.Success, response.Message);
        }

        [Fact]
        public void When_trying_to_register_a_product_with_zero_price_returns_an_error()
        {
            var command = new CreateProductCommand();
            command.Name = "Product XPTO";
            command.Price = 0;

            var response = _handler.Handle(command);

            Assert.False(response.Success, response.Message);
        }

        [Fact]
        public void When_trying_to_register_a_product_with_a_negative_price_it_returns_an_error()
        {
            var command = new CreateProductCommand();
            command.Name = "Product XPTO";
            command.Price = -5.00m;

            var response = _handler.Handle(command);

            Assert.False(response.Success, response.Message);
        }

        [Fact]
        public void When_trying_to_register_null_product_returns_error()
        {
            var command = new CreateProductCommand();
            command = null;

            var response = _handler.Handle(command);

            Assert.False(response.Success, response.Message);
        }
    }
}