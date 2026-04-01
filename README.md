# 🐉 Dragon Ball API

API REST desenvolvida com **ASP.NET Core** para gerenciamento de personagens do universo Dragon Ball.

---

## 📌 Sobre o projeto

Esta API foi construída com foco em boas práticas de desenvolvimento backend, incluindo:

* Arquitetura em camadas (Controller, Service, Data, Model)
* Uso de injeção de dependência
* Persistência com Entity Framework Core
* Banco de dados PostgreSQL
* Documentação automática com Swagger

---

## 🧱 Arquitetura

O projeto segue uma arquitetura em camadas (Layered Architecture), separando responsabilidades entre apresentação, aplicação e acesso a dados:

```
📦 Dragon-Ball
 ┣ 📂 Controllers
 ┃ ┗ 📄 PersonagemController.cs   → Responsável por receber requisições HTTP e retornar respostas
 ┣ 📂 Services
 ┃ ┣ 📂 Interfaces
 ┃ ┃ ┗ 📄 IPersonagemService.cs   → Contrato das regras de negócio
 ┃ ┗ 📄 PersonagemService.cs      → Implementação das regras de negócio
 ┣ 📂 Data
 ┃ ┗ 📄 AppDbContext.cs           → Configuração do Entity Framework e acesso ao banco
 ┣ 📂 Models
 ┃ ┗ 📄 Personagem.cs             → Entidade que representa a tabela no banco
 ┣ 📂 Migrations                  → Controle de versão do banco de dados
```

**Fluxo da aplicação:**

```
Cliente → Controller → Service → DbContext → Banco de Dados
```

---

## 🚀 Tecnologias utilizadas

* .NET 8
* ASP.NET Core Web API
* Entity Framework Core
* PostgreSQL
* Npgsql
* Swagger (OpenAPI)

---

## 🗄️ Banco de dados

A aplicação utiliza PostgreSQL como banco de dados relacional.

### 🔗 Configuração

```json
"ConnectionStrings": {
  "AppDbConectionString": "Host=localhost;Port=5432;Database=DBZ;Username=postgres;Password=123"
}
```

---

## ⚙️ Como executar o projeto

### 🔹 Pré-requisitos

* .NET SDK 8 instalado
* PostgreSQL em execução

---

### 🔹 Passos

```bash
# Clonar o repositório
git clone https://github.com/seu-usuario/dragon-ball-api.git

# Acessar a pasta
cd dragon-ball-api

# Restaurar dependências
dotnet restore

# Aplicar migrations
dotnet ef database update

# Executar a aplicação
dotnet run
```

---

## 📖 Documentação da API (Swagger)

Após iniciar o projeto, acesse:

```
https://localhost:7235/swagger
```

---

## 📌 Endpoints

| Método | Rota                 | Descrição            |
| ------ | -------------------- | -------------------- |
| POST   | /api/personagem      | Criar personagem     |
| GET    | /api/personagem      | Listar todos         |
| GET    | /api/personagem/{id} | Buscar por ID        |
| PUT    | /api/personagem/{id} | Atualizar personagem |
| DELETE | /api/personagem/{id} | Remover personagem   |

---

## 🔄 Exemplo de requisição (PUT)

```http
PUT /api/personagem/1
```

```json
{
  "name": "Vegeta",
  "tipo": "Saiyajin",
  "poder": 9500
}
```

---

## 🧠 Modelo de dados

```json
{
  "id": 1,
  "name": "Goku",
  "tipo": "Saiyajin",
  "poder": 9000
}
```

---

## 🛠️ Boas práticas aplicadas

* ✔ Injeção de dependência
* ✔ Separação de responsabilidades
* ✔ Uso de async/await
* ✔ Validação com Data Annotations
* ✔ Padrão REST (uso de PUT para atualização completa)
* 
---

## 👨‍💻 Autor

Desenvolvido por **Pabline Pereira**
