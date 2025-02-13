Este é um projeto simples para exemplo de uso do DDD.

Domain-Driven Design (DDD) é uma abordagem para desenvolvimento de software que coloca o domínio do problema no centro do design do sistema. O conceito foi introduzido por Eric Evans no livro Domain-Driven Design: Tackling Complexity in the Heart of Software.

## Principais Conceitos do DDD
1. Ubiquitous Language (Linguagem Ubíqua)

    * Um vocabulário compartilhado entre desenvolvedores e especialistas do domínio para evitar ambiguidades e garantir que o software reflita corretamente o negócio.
2. Bounded Context (Contexto Delimitado)

    * Sistemas complexos são divididos em múltiplos contextos independentes, cada um com seu próprio modelo de domínio. Isso ajuda a evitar conflitos conceituais e melhora a organização da aplicação.
3. Entities (Entidades)

    * Objetos com identidade única dentro do domínio. Exemplo: um cliente identificado por um ID.
4. Value Objects (Objetos de Valor)

    * Objetos sem identidade própria, definidos apenas pelos seus atributos. Exemplo: um endereço dentro do cadastro de um cliente.
5. Aggregates (Agregados)

    * Conjunto de entidades e objetos de valor que devem ser tratados como uma unidade de consistência. Um agregado raiz controla o acesso e as modificações dentro dele.
6. Repositories (Repositórios)

    * Camada de abstração para buscar e armazenar entidades do domínio, geralmente acessando o banco de dados.
7. Domain Services (Serviços de Domínio)

    * Lógica de negócio que não pertence a uma entidade ou valor específico. Exemplo: um serviço que calcula a melhor taxa de juros para um empréstimo.
8. Event Storming & Domain Events

    * Técnicas para modelar o domínio por meio de eventos que ocorrem no sistema.
## Por que usar DDD?
* Ajuda a lidar com sistemas complexos.
* Aproxima desenvolvedores e especialistas do domínio.
* Melhora a modularidade e a manutenibilidade do código.
* Facilita a evolução do software sem comprometer o negócio.