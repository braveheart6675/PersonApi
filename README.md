# PersonManagement gRPC Service 🚀

![.NET](https://img.shields.io/badge/.NET-6.0-purple)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-6.0-blue)
![gRPC](https://img.shields.io/badge/gRPC-2.42.0-green)
![Entity Framework](https://img.shields.io/badge/Entity_Framework_Core-6.0-orange)

A high-performance Person Management gRPC service built with **ASP.NET Core** and **Entity Framework Core**, demonstrating modern gRPC implementation with both gRPC and REST endpoints.

## 📋 Table of Contents
- [✨ Features](#-features)
- [🏗️ Architecture & Tech Stack](#️-architecture--tech-stack)
- [🚀 Quick Start](#-quick-start)
- [📡 API Endpoints](#-api-endpoints)
- [🔧 Project Structure](#-project-structure)
- [🛠️ Development](#️-development)
- [🐳 Docker Support](#-docker-support)
- [🤝 Contributing](#-contributing)

## ✨ Features

- **⚡ High-Performance gRPC** - Binary protocol for fast communication
- **🔄 Dual Protocol Support** - Both gRPC and REST APIs
- **🛢️ Entity Framework Core** - Data access with SQL Server
- **📚 Swagger Documentation** - REST API documentation
- **🎯 Clean Architecture** - Separation of concerns
- **🔒 Error Handling** - Comprehensive error management
- **🐳 Docker Ready** - Containerized deployment

## 🏗️ Architecture & Tech Stack

### Core Technologies
- **.NET 6.0** - Cross-platform framework
- **ASP.NET Core** - Web API framework
- **gRPC for .NET** - High-performance RPC
- **Entity Framework Core** - ORM and data access
- **SQL Server** - Database (configurable)
- **Protocol Buffers** - Interface definition

### Protocols & Tools
- **gRPC** - Primary communication protocol
- **REST API** - Secondary HTTP endpoints
- **Swagger/OpenAPI** - API documentation
- **Docker** - Containerization

## 🚀 Quick Start

### Prerequisites
- .NET 6.0 SDK
- SQL Server (LocalDB or full)
- Visual Studio 2022 / VS Code

### Installation

1. **Clone the repository**
```bash
git clone https://github.com/braveheart6675/PersonManagement-gRPC.git
cd PersonManagement-gRPC

Database setup
Update appsettings.json:

json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PersonManagement;Trusted_Connection=true;"
  }
}

Run database migrations

bash
dotnet ef database update

Run the application

bash
dotnet run

Access Points
gRPC Service: https://localhost:7001

REST API: https://localhost:7001/api/person

Swagger UI: https://localhost:7001/swagger

📡 API Endpoints
gRPC Services
protobuf
service PersonService {
  rpc CreatePerson (CreatePersonRequest) returns (PersonResponse);
  rpc GetPerson (GetPersonRequest) returns (PersonResponse);
  rpc GetAllPersons (GetAllPersonsRequest) returns (PersonsResponse);
  rpc UpdatePerson (UpdatePersonRequest) returns (PersonResponse);
  rpc DeletePerson (DeletePersonRequest) returns (DeletePersonResponse);
}

REST Endpoints

Method	Endpoint	Description
GET	/api/person	Get all persons
GET	/api/person/{id}	Get person by ID
POST	/api/person	Create new person
PUT	/api/person/{id}	Update person
DELETE	/api/person/{id}	Delete person

🔧 Project Structure
text
PersonManagement-gRPC/
├── Protos/                 # gRPC service definitions
│   └── person.proto
├── Services/              # gRPC service implementations
├── Controllers/           # REST API controllers
├── Models/               # Data models and entities
├── Data/                # DbContext and data access
├── Migrations/          # Database migrations
├── Properties/          # Project configuration
└── Program.cs           # Application entry point

🛠️ Development
Build and Run
bash
dotnet build
dotnet run
Database Management
bash
# Create new migration
dotnet ef migrations add InitialCreate

# Update database
dotnet ef database update

gRPC Client Testing
Use tools like:

BloomRPC - GUI gRPC client

grpcurl - Command line tool

Postman - Latest versions support gRPC

🐳 Docker Support
Docker Compose
version: '3.8'
services:
  person-api:
    build: .
    ports:
      - "7001:80"
    environment:
      - ConnectionStrings__DefaultConnection=Server=db;Database=PersonManagement;User=sa;Password=YourPassword123;
    depends_on:
      - db

  db:
    image: mcr.microsoft.com/mssql/server:2019-latest
    environment:
      SA_PASSWORD: "YourPassword123"
      ACCEPT_EULA: "Y"

Docker Commands
bash
docker build -t personmanagement-grpc .
docker run -p 7001:80 personmanagement-grpc
🤝 Contributing
Contributions welcome! Please feel free to submit PRs or open issues.

Fork the repository

Create your feature branch (git checkout -b feature/AmazingFeature)

Commit your changes (git commit -m 'Add some AmazingFeature')

Push to the branch (git push origin feature/AmazingFeature)

Open a Pull Request

📄 License
This project is licensed under the MIT License - see the LICENSE file for details.

⭐ Star this repo if you find it helpful!

Built with ❤️ using ASP.NET Core gRPC