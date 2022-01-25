## Factory Pattern

O padrão de projeto Abstract Factory fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

A palavra chave aqui é **Famílias**. Uma família (singular) de objetos significa várias classes que implementam a mesma interface/contrato. O pattern Factory 
Method lida com apenas uma família. 

Já o pattern Abstract Factory lida com famílias de objetos. Ou seja, se trata de uma Fabrica de objetos com interfaces diferentes.

Veja que o Abstract Factory meio que implementa o pattern **Facade**, para agrupar/simplificar o acesso aos vários métodos de várias familias de objetos relacionados
de alguma forma, no mesmo local.
