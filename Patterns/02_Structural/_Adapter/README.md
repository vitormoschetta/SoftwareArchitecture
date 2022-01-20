### Contexto:

Temos uma classe chamada `DbCommand` que implementa um contrato `IDbCommand`. No contrato existem três métodos:

1. **Insert**
2. **Update**
3. **Delete**

### Problema

Agora precisamos que a classe `DbCommand` (Target) invoque os métodos da classe `MySqlCommand` (Adaptee), 
sem deixar de implementar o contrato `IDbCommand`. 

Perceba que os métodos existentes no contrato `IDbCommand` divergem dos nomes de métodos existentes na classe `MySqlCommand`. 
Precisamos criar um adaptador (Adapter):

`DbCommandAdapter` implementa a interface `IDbCommand`, ao mesmo tempo que implementa uma composição via construtor com 
`MySqlCommand`. Dessa forma, de dentro dos métodos padrões do contrato podemos invocar os métodos de `MySqlCommand`.

Criamos um adaptador para acessar os métodos de uma classe que diverge de nosso contrato.