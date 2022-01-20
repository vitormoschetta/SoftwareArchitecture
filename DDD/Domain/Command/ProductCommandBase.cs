using System;

namespace Domain.Command
{
    /// <summary>
    /// Estamos fazendo a validação dos dados no command/parametros de entrada ao invés de
    /// fazermos na entidade de domínio (Models/Product). 
    /// O motivo dessa validação estar aqui é porque em muitos casos a entidade de domínio 
    /// não vai conseguir validar em um único método todos os casos/fluxos possíveis.
    /// Uma validação de cadastro pode ser diferente de uma validação de atualização.
    /// Logo, quando mantemos a validação nos commands, temos validaçoes mais específicas e 
    /// mais eficientes.    
    /// </summary>
    /// <summary>
    /// Existem várias bibliotecas que facilitam essa tarefa de validação. Alem de o código ficar
    /// bem mais enxuto, fornecem uma funcionalidade muito importante em uma validação:
    /// Agrupamento de todos os erros de validação de uma única vez a cada requisição.
    /// Em nosso método de validação abaixo (Validate), quando identificamos um erro, retornamos
    /// imediatamente esse erro. Dessa forma o cliente nunca vai poder corrigir todos os erros
    /// de uma só vez, caso houverem. 
    /// </summary>
    public abstract class ProductCommandBase
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("Informe o nome do Produto!");

            if (Name.Length < 5)
                throw new Exception("O Nome do Produto deve conter pelo menos 5 (cinco) caracteres.");

            if (Price == null || Price <= 0)
                throw new Exception("Informe um preço válido ao Produto.");

        }
    }
}