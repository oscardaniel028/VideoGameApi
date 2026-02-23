# 🎮 VideoGameApi

RESTful Web API built with ASP.NET Core for managing video games.  
This project implements a layered architecture using the Repository Pattern and JWT authentication, following clean code principles and separation of concerns.

---

## 🚀 Technologies

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- Repository Pattern
- Dependency Injection

---

## 🏗 Architecture

The project follows a layered architecture:

Controllers → Services → Repositories → DbContext → Database

- **Controllers** handle HTTP requests.
- **Services** contain business logic.
- **Repositories** manage data access.
- **DbContext** interacts with the database.

This structure improves scalability, maintainability, and testability.

---

## 🔐 Authentication

Authentication is implemented using JWT (JSON Web Tokens).

- Users must log in to receive a token.
- Protected endpoints require a valid Bearer token.
- Passwords are securely hashed before storage.

---

## 📌 Features

- CRUD operations for video games
- User authentication
- Layered architecture
- Repository Pattern implementation
- Clean and maintainable structure

---

## ⚙️ How to Run the Project

1. Clone the repository:
git clone https://github.com/oscardaniel028/VideoGameApi.git

3. Update the connection string in `appsettings.json`.

4. Run database migrations (if applicable):
dotnet ef database update

## 📄 Author

Oscar Sanchez  
Backend Developer (.NET)
