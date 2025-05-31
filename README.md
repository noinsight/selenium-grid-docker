# Solution with Docker, Selenium, and Razor Pages

This .NET 6 solution is based on a Selenium/Docker course on Udemy.   
It features:
- **ProductAPI**: A RESTful API for product management.
- **EAWebApp**: A Razor Pages web application for interacting with the API.
- **EAAppTest**: A couple of tests that use Selenium Grid.
- **ea_network**: A Docker network connecting all containers.

---

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
- [Development](#development)
- [Docker Support](#docker-support)

---

## Features

- Product CRUD operations via REST API
- Razor Pages frontend for product management
- Entity Framework Core with SQL Server
- Data seeding for development
- Swagger/OpenAPI documentation
- Dockerized for easy deployment

---

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/)

---

## API Endpoints

- `GET /api/products` - List all products
- `GET /api/products/{id}` - Get product by ID
- `POST /api/products` - Create a new product
- `PUT /api/products/{id}` - Update a product
- `DELETE /api/products/{id}` - Delete a product

See Swagger UI at `/swagger` for full API documentation.

---

## Development

- Code style is enforced via `.editorconfig` and [StyleCop.Analyzers](https://www.nuget.org/packages/StyleCop.Analyzers).
- Data is seeded automatically in development via `SeedData.cs`.

---

## Docker Support

Build the solution and run the tests with Docker Compose:
---

docker-compose up --build

---

