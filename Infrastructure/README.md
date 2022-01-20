### Arquitetura em grandes volumes de Escrita / Persistência

- Uma boa estratégia seria gerenciar os dados de entrada em uma fila (**Kafka** por exemplo), e garantir que milhares de dados não estarão tentando escrever ao mesmo tempo.

Dessa forma, um **worker** (serviço rodando em background no seu app) pode ir desempilhando os registros da fila e gravando no banco de dados.

### Arquitetura em grandes volumes de Leitura 

- Usar uma estratégia de **cache de memória**. Pode ser feito na própria aplicação, porém o mais recomendado seria usando um servidor separado (**Redis** por exemplo).
Toda consulta vai primeiro no cache. Se a informação não for encontrada, aí sim vai no banco de dados, e se achar no banco, já atualiza o cache e devolve a resposta.

- **Desnormalizar** tabelas de banco de dados também é uma boa prática para melhorar performance nas leituras. Isso significa diminuir a necessidade de relacionamentos entre várias tabelas para gerar a informação desejada. Podemos aplicar isso mantendo na mesma tabela todos os relacionamentos  **1 x 1** ou criando uma terceira tabela que é populada pelas tabelas originais e serve apenas para leitura. Uma **View** materializada também serve bem a esse propósito.

Sem mencionar que mesmo em alguns casos de relacionamento **1 x N** ainda é uma boa desnormalizar se esses dados nunca mudam. Ex:

```
COD |    ESTADO
------------------
1          SAO PAULO
2          RIO DE JANEIRO
```

```
COD |    CIDADE    |    ESTADOFK
-----------------------------
1        MOGI MIRIM     1
2        COPA CABANA    1
```

As duas tabelas acim poderiam ser uma:
```
COD |    CIDADE    |    ESTADO
-----------------------------
1        MOGI MIRIM     SAO PAULO
2        SANTOS         SAO PAULO
3        COPA CABANA    RIO DE JANEIRO
```


### Arquitetura para pesquisa textual

**Elastic Search** é uma boa ferramenta de pesquisa. Neste caso, precisaríamos persistir a escrita tanto no banco relacional quanto no Elastic. E a leitura seria feita no Elastic.