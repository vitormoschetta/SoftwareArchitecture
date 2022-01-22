## Factory

É possível criar fábricas a partir de **classes abstratas** e/ou a partir de **interfaces**. O que precisamos levar em consideração ao decidir entre uma e outra?

Se as classes concretas geradas pela fábrica não tiver nada em comum entre elas, podemos usar interfaces. Do contrário, usamos classe abstrata e já implementamos 
nela as funcionalidades comum das classes concretas.