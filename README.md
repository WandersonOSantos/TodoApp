# Anotações:

*Obs: Para este projeto, foi criado uma feature para cada aula, visando a prática do uso do git, e não a entrega de valor propriamente dito. Em um cenário business a ideia é que cada feature realmente seja uma entrega de valor. Como modelo de fluxo, utilizei o gitflow (também para estudo) apesar de no curso original (balta.io) não ter nenhuma implementação de git.

1 - Criação da estrutura de pastas

2 - Criação dos projetos

3 - Criação do sln (solution)

4 - Adição dos projetos à solution

5 - Criação da referencia entre os projetos
    Obs: Domain nunca referencia nenhum projeto, ele sempre será referenciado (caso contrário, problema de referencia cruzada).

6 - Registrado biblioteca Flunt (balta.io)

# Designs/Patterns utilizados:

1 - Design by contracts
    - Usado para padronizar as chamadas ao domínio.

2 - Repository Pattern
    - Unidade de acesso a dados.
    - Divide responsabilidades (o sistema passa a não se importar onde os dados serão armazenados).

2 - Abordado sobre a técnica de red green refactor (testes)