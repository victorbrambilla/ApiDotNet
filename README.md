# ApiDotNet Clean Architecture

O projeto ApiDotNet é uma aplicação desenvolvida em .NET 6 com Clean Architecture. Ele consiste em uma API que segue as boas práticas de organização de pastas e separação de responsabilidades.

## Pré-requisitos

Antes de configurar e executar o projeto, verifique se o seguinte software está instalado no seu ambiente de desenvolvimento:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [PostgreSQL](https://www.postgresql.org/)

## Configuração do Ambiente

Siga as instruções abaixo para configurar o ambiente de desenvolvimento e executar o projeto:

1. Clone o repositório: `git clone https://github.com/victorbrambilla/ApiDotNet.git`
2. Acesse o diretório do projeto: `cd ApiDotNet`
3. Restaure as dependências: `dotnet restore`

## Estrutura do Projeto

A estrutura do projeto segue a arquitetura limpa (Clean Architecture) para uma melhor separação de responsabilidades. A seguir está a estrutura de pastas do projeto:

├── ApiDotNet.sln

├── ApiDotNet.Api

├── ApiDotNet.Application

├── ApiDotNet.Domain

├── ApiDotNet.Infra.Data

└── ApiDotNet.Infra.IoC


- `ApiDotNet.Api`: Contém a camada da API, responsável pelas rotas, controladores e autenticação.
- `ApiDotNet.Application`: Camada da aplicação, contendo os casos de uso e serviços.
- `ApiDotNet.Domain`: Nesta camada estão as entidades de domínio e as interfaces de repositório.
- `ApiDotNet.Infra.Data`: Implementações concretas de repositório e acesso a dados.
- `ApiDotNet.Infra.IoC`: Configurações de injeção de dependência da aplicação.

## Entidades

As entidades principais do domínio do projeto são:

- `Permission`: Representa uma permissão dentro do sistema.
- `Person`: Representa uma pessoa.
- `Product`: Representa um produto disponível.
- `Purchase`: Representa uma compra realizada por um usuário.
- `User`: Representa um usuário do sistema.
- `UserPermission`: Relaciona um usuário às permissões que ele possui.

## Bibliotecas Utilizadas

Além das bibliotecas mencionadas anteriormente, você também está utilizando as seguintes bibliotecas:

- [AutoMapper](https://automapper.org/)

- [Isopoh.Cryptography.Argon2](https://github.com/mheyman/Isopoh.Cryptography.Argon2)

- [Fluent Validation](https://docs.fluentvalidation.net/en/latest/)

- [Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)

- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

## Migrations

O projeto utiliza migrações do Entity Framework Core para gerenciar o esquema do banco de dados. As migrações permitem que você versione e aplique alterações no banco de dados de forma controlada.

Para executar as migrações e atualizar o banco de dados, siga as etapas abaixo:

1. Certifique-se de ter configurado corretamente a conexão com o banco de dados PostgreSQL no arquivo `appsettings.json` da camada `ApiDotNet.Api` e no aquivo `AppDbContextFactory` da camada `ApiDotNet.Infra.Data`
2. Abra um terminal no projeto `ApiDotNet.Infra.Data`.
3. Execute o seguinte comando para criar um novo banco de dados e aplicar as migrações iniciais:

   ```bash
   dotnet ef database update

