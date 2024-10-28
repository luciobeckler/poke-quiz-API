# PokeQuiz.API

API em C# com .NET para servir uma aplicação de Quiz, utilizando SQL Server como banco de dados.

## Índice

- [Introdução](#introdução)
- [Requisitos](#requisitos)
- [Configuração](#configuração)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [End-points](#end-points)
---

## Introdução

Esta API foi desenvolvida com .NET para servir a aplicação front-end React que implementa a interface de quiz presente neste [link](https://github.com/luciobeckler/poke-quiz-app). A API fornece endpoints para operações CRUD (Create, Read, Update, Delete) com um banco de dados SQL Server.

### Tecnologias Utilizadas

- C# com .NET (especifique a versão, ex. `.NET 6`)
- SQL Server
- Entity Framework, Swagger

## Requisitos

- **SDK .NET**: [link para instalação](https://dotnet.microsoft.com/download)
- **SQL Server**: [link para download](https://www.microsoft.com/sql-server)
- **Ferramenta de Gerenciamento SQL**: [SQL Server Management Studio](https://docs.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms)

## Configuração
### Passo 1: Clonar o Repositório

```bash
git clone https://github.com/luciobeckler/poke-quiz-api.git
cd poke-quiz-api
```

### Passo 2: Configurar o Banco de Dados
- Crie um banco de dados no SQL Server. Exemplo:
```bash
CREATE DATABASE NomeDoBanco;
```
- Atualize a string de conexão para apontar para o banco de dados SQL Server. Em appsettings.json:
```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=NomeDoBanco;User Id=SEU_USUARIO;Password=SUA_SENHA;"
  }
}
```
- Execute as migrations, se aplicável, para criar as tabelas necessárias:
```bash
dotnet ef database update
```

### Passo 3: Rodar o Projeto
```bash
dotnet run
```

## Estrutura do projeto:
- Controllers: Contém os controladores da API, que definem os endpoints.
- Models: Define as entidades do banco de dados.
- Migrations: Gerencia a configuração do banco de dados e migrations.
- Services: Contém a lógica de negócios (Será implementado no futuro).
- appsettings.json: Arquivo de configuração, incluindo string de conexão.

## End-points
![image](https://github.com/user-attachments/assets/8b0c9823-17ee-4d56-88f1-2359f66c3d1b)


