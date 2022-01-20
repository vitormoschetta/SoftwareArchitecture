### Singleton

Singleton é um Pattern que impede que mais de uma instância de uma determinada classe sejam criadas, ou seja, essa classe é instanciada uma única vez. 

A lógica necessária é: 

1. Pede uma instância da classe
2. Verifica se já existe uma instância dessa classe
3. Se não existir nenhuma instancia, cria uma
4. Se já existir uma instancia, retorna a que já existe

Fazemos isso usando uma propriedade e um método estático. 

O Construtor é o meio de inicializar um objeto em CSharp. Se queremos ter o controle sobre as instâncias de uma classe, precisamos limitar o acesso ao Construtor também.

