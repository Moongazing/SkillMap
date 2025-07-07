# SkillMap 🧠

**SkillMap** is a developer-focused GraphQL-based platform that allows users to track and manage their technical skills. Built with ASP.NET Core, HotChocolate GraphQL, and PostgreSQL using a layered architecture.

---

## ✨ Features

- 🔍 Query developer profiles and skills via GraphQL
- 🛠 Add skills with levels (Beginner to Expert)
- 📡 Built with HotChocolate GraphQL
- 🧱 PostgreSQL & EF Core-backed data store
- 🧩 Modular architecture (Domain, Application, Infrastructure, API)
- 🧪 Ready for unit testing
- 🐳 Docker support (optional)

---

## 🧰 Tech Stack

| Layer         | Tech |
|---------------|------|
| API           | ASP.NET Core 8, HotChocolate GraphQL |
| Application   | Mapster, FluentValidation |
| Infrastructure| EF Core, PostgreSQL |
| GraphQL UI    | Banana Cake Pop |
| Testing       | xUnit, Moq, EFCore.InMemory (optional) |

---

## 🗂 Project Structure

SkillMap/
├── SkillMap.API # GraphQL Gateway
├── SkillMap.Application # Business logic, DTOs, Services
├── SkillMap.Domain # Core entities & enums
├── SkillMap.Infrastructure # EF Core, PostgreSQL, services
├── SkillMap.Tests # Unit tests (optional)


---

## 🚀 Getting Started

### 📦 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/)
- (Optional) [Docker](https://www.docker.com/)

---

### ⚙️ Configuration

Update your `appsettings.json` in `SkillMap.API`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=skillmapdb;Username=postgres;Password=yourpassword"
}

🧱 Database Setup

Run EF Core migration:

dotnet ef migrations add InitialCreate -p SkillMap.Infrastructure -s SkillMap.API
dotnet ef database update -p SkillMap.Infrastructure -s SkillMap.API

▶️ Run the App

dotnet run --project SkillMap.API

Navigate to: http://localhost:5000/graphql

Use Banana Cake Pop to interact with the API.
🔎 Sample GraphQL Queries
➕ Create a User

mutation {
  createUser(input: {
    username: "tunahan",
    email: "tuna@skillmap.dev"
  }) {
    id
    username
    email
  }
}

➕ Add Skill

mutation {
  addSkill(input: {
    userId: "user-guid",
    name: "GraphQL",
    level: EXPERT
  }) {
    id
    name
    level
  }
}

🔍 Get All Users

query {
  getUsers {
    id
    username
    email
    skills {
      name
      level
    }
  }
}

🧪 Tests (Optional)

dotnet test SkillMap.Tests

🪪 License

This project is licensed under the MIT License — see the LICENSE file for details.
👨‍💻 Author

Made by Tunahan Ali Öztürk
