📌 Overview
A modern and efficient API service for managing person information with support for both gRPC and REST protocols.
PersonApi is a lightweight gRPC-based CRUD service built with .NET.
It demonstrates how to define protobuf contracts, implement gRPC services, and consume them using a client application.

This project is ideal for learning:

gRPC Server & Client implementation

Using Protobuf (.proto files)

Structuring a simple .NET gRPC API

Running and testing RPC-based CRUD operations



✨ Features
📡 Dual Protocol Support: gRPC for high performance and REST for broad compatibility

🛢️ In-Memory Storage: Repository pattern with temporary storage

🔒 Error Handling: Comprehensive error handling implementation

📚 Swagger Documentation: Automated API documentation with Swagger/OpenAPI

🎯 Clean Architecture: Standard and extensible project structure


🏗️ Project Architecture
PersonApi.sln
│
├── PersonApi/                 # gRPC server project
│    ├── Protos/               # .proto definitions
│    ├── Services/             # gRPC service implementations
│    ├── Models/               # Person model
│    └── Program.cs            # App entry point
│
└── PersonClient/              # gRPC client project
     └── Program.cs            # Sample client to test CRUD operations



🚀 Getting Started
Prerequisites
.NET 6.0 SDK or later

Visual Studio 2022 or VS Code

(Optional) Postman for API testing

1- Installation
git clone https://github.com/braveheart6675/PersonApi.git
cd PersonApi
2- Restore dependencies
dotnet restore
3- Run the application
dotnet run
4- Access the application

REST API: https://localhost:7001

gRPC Service: https://localhost:7001

Swagger UI: https://localhost:7001/swagger


📡 API Endpoints
REST API
Method	Endpoint	Description
GET	/api/person	Get all persons
GET	/api/person/{id}	Get person by ID
POST	/api/person	Create new person
PUT	/api/person/{id}	Update existing person
DELETE	/api/person/{id}	Delete person
gRPC Services
The project includes gRPC service definitions for:

GetAllPersons - Retrieve all persons

GetPersonById - Get specific person by ID

CreatePerson - Create new person

UpdatePerson - Update existing person

DeletePerson - Remove person


🛠️ Development
Building the Project
dotnet build
Running Tests
dotnet test
Code Structure
Controllers/: HTTP REST API controllers

Services/: Business logic and service layer

Protos/: gRPC service contract definitions (.proto files)

Models/: Data transfer objects and entities

Repositories/: Data access abstraction layer



📌 Possible Improvements

You may enhance this project by adding:

Database integration (EF Core + SQL Server / SQLite)

Authentication & Authorization

Global exception handling / logging middleware

Unit & integration tests

Docker support

gRPC-Web support for browser clients



🔧 Configuration
The application can be configured through appsettings.json:
{
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  },
  "Kestrel": {
    "EndpointDefaults": {
      "Protocols": "Http1AndHttp2"
    }
  }
}



📚 Usage Examples
REST API Example

# Get all persons
curl -X GET https://localhost:7001/api/person

# Create new person
curl -X POST https://localhost:7001/api/person \
  -H "Content-Type: application/json" \
  -d '{"name": "John Doe", "email": "john@example.com"}'

  gRPC Client Example
  // Example gRPC client usage
var channel = GrpcChannel.ForAddress("https://localhost:7001");
var client = new PersonService.PersonServiceClient(channel);

var response = await client.GetAllPersonsAsync(new GetAllPersonsRequest());



🤝 Contributing
Fork the repository

Create a feature branch (git checkout -b feature/amazing-feature)

Commit your changes (git commit -m 'Add some amazing feature')

Push to the branch (git push origin feature/amazing-feature)

Open a Pull Request



📄 License
This project is licensed under the MIT License - see the LICENSE file for details.


🐛 Issue Reporting
If you find any bugs or have feature requests, please create an issue in the GitHub Issues section.


🙏 Acknowledgments

Built with ASP.NET Core 6

gRPC for .NET


Swagger for API documentation


