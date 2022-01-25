### Singleton

O padrão de design Singleton garante que uma classe tenha apenas uma instância e forneça um ponto global de acesso a ela.

A lógica necessária é: 

1. Pede uma instância da classe
2. Verifica se já existe uma instância dessa classe
3. Se não existir uma instancia, cria
4. Se já existir uma instancia, retorna a que já existe

Fazemos isso usando uma propriedade e um método estático. 

O Construtor é o meio de inicializar um objeto em CSharp. Se queremos ter o controle sobre as instâncias de uma classe, precisamos limitar o acesso ao Construtor.

