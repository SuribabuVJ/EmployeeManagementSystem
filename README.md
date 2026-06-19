# Employee Management System

## Project Overview

Employee Management System is a web application developed using ASP.NET Core MVC, ASP.NET Core Web API, Entity Framework Core, and MySQL.

The application follows a 3-Tier Architecture and allows users to perform CRUD (Create, Read, Update, Delete) operations on employee records.

---

## Technologies Used

* ASP.NET Core MVC (.NET 8)
* ASP.NET Core Web API
* Entity Framework Core
* MySQL
* C#
* Bootstrap
* Swagger

---

## Project Architecture

Employee.UI (MVC)
↓
HttpClient
↓
Employee.API
↓
Entity Framework Core
↓
MySQL Database

---

## Solution Structure

EmployeeSolution

├── Employee.UI
│   ├── Controllers
│   ├── Models
│   └── Views
│
├── Employee.API
│   ├── Controllers
│   ├── DTOs
│   └── Data
│
├── Employee.Business
│   ├── EntityModels
│   ├── Interfaces
│   ├── Repository
│   └── BusinessLogic
│
└── MySQL Database

---

## Features

### Employee Management

* View Employee List
* Add Employee
* Edit Employee
* Delete Employee

### API Features

* Get All Employees
* Get Employee By Id
* Create Employee
* Update Employee
* Delete Employee

### Database Features

* Employee Data Storage
* Entity Framework Core Integration
* MySQL Connectivity

---

## Employee Entity

```csharp
public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Department { get; set; }

    public decimal Salary { get; set; }
}
```

---

## API Endpoints

### Get All Employees

GET

/api/Employee

### Get Employee By Id

GET

/api/Employee/{id}

### Create Employee

POST

/api/Employee

### Update Employee

PUT

/api/Employee

### Delete Employee

DELETE

/api/Employee/{id}

---

## Database Table

Employees

| Column     | Data Type |
| ---------- | --------- |
| Id         | INT       |
| Name       | VARCHAR   |
| Email      | VARCHAR   |
| Department | VARCHAR   |
| Salary     | DECIMAL   |

---

## How to Run the Project

### Clone Repository

git clone <repository-url>

### Open Solution

Open EmployeeSolution.sln in Visual Studio 2022.

### Configure Database

Update appsettings.json with your MySQL connection string.

### Run API Project

Start Employee.API.

### Run MVC Project

Start Employee.UI.

### Test API

Open Swagger and test API endpoints.

---

## Learning Outcomes

This project helped me learn:

* ASP.NET Core MVC
* ASP.NET Core Web API
* Entity Framework Core
* MySQL Database Integration
* CRUD Operations
* Dependency Injection
* 3-Tier Architecture
* HttpClient Communication
* Repository Pattern Basics

---

## Future Enhancements

* Search Employee
* Pagination
* Authentication & Authorization
* Department Management Module
* Validation
* Logging & Exception Handling

---

## Author

Suribabu VJ

ASP.NET Core Developer
