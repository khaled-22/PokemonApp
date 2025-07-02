#  Pokemon Review API
A RESTful Web API built with ASP.NET Core that allows users to review and rate their favorite Pokémon. This project demonstrates clean architecture, repository patterns, dependency injection, and unit testing in a .NET environment.


## About the Project

This API mimics a review system similar to Rotten Tomatoes or IMDB, but for **Pokemon**. Each Pokemon can have multiple reviews submitted by users, including a rating (1–5 stars) and written feedback.

The goal of this project is to teach and demonstrate:

- Clean **separation of concerns** using controllers, services, repositories, and DTOs.
- Use of **Entity Framework Core** with a code-first approach.
- Implementing **Dependency Injection (DI)** to decouple business logic from infrastructure.
- Writing **unit tests** to ensure reliability.
- Laying a foundation that can scale to include user authentication, frontend integration, or third-party data sources.

---

##  Key Components

###  Models
- `Pokemon`: Represents a Pokemon with its name and category.
- `Review`: Stores user-submitted reviews for each Pokémon.
- `Reviewer`: Represents a user who writes reviews.
- `Owner`: A Pokémon owner or trainer (optional relationship).

###  Data Layer
- Uses **Entity Framework Core** with an in-memory database (easily replaceable with SQL Server).
- Relationships:
  - One Pokemon → Many Reviews
  - One Reviewer → Many Reviews
