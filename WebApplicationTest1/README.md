# WebApplicationTest1

A simple ASP.NET Core Web API for managing employees, departments, and projects, demonstrating basic CRUD operations and entity relationships using Entity Framework Core.

## Features

- Manage Employees, Departments, and Projects
- Assign employees to projects (many-to-many relationship)
- Retrieve employees by project, employees above a certain age, and employee counts by department
- Expose RESTful endpoints for core operations
- Swagger/OpenAPI documentation enabled

## Technologies

- .NET 8
- C# 12
- ASP.NET Core Web API
- Entity Framework Core (Code First, SQL Server)
- Swagger (Swashbuckle)

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Setup

1. **Clone the repository:**
2. **git clone `https://github.com/anuja-rg/WebApplicationTest1` cd WebApplicationTest1**
2. **Configure the database:**
   - Update the `DefaultConnection` string in `appsettings.json` to point to your SQL Server instance.
3. **Apply migrations:**
4. **Run the application:**
5. **Access the API:**
   - Swagger UI: [https://localhost:5001/swagger](https://localhost:5001/swagger) (or the port shown in your console)

## Project Structure

- `Controllers/` - API endpoints for Employees and Departments
- `Models/` - Entity classes: Employee, Department, Project, EmployeeProject
- `DTO/` - Data Transfer Objects for API responses
- `Repository/` - Repository interfaces and implementations for data access
- `Service/` - Business logic layer
- `Migrations/` - Entity Framework Core migrations

## Example Endpoints

- `GET /api/employee` - Test endpoint
- `GET /api/employee/projects/{projectId}` - Get employees by project
- `GET /api/employee/above20` - Get employees older than 20
- `GET /api/employee/with-projects` - Get all employees with their projects

## License

This project is licensed under the MIT License.
