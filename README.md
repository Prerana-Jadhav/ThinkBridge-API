# ThinkBridge Invoice API

A RESTful backend API built with ASP.NET Core (.NET 8) for serving invoice data. Includes Swagger UI for interactive API documentation.

## Description

This backend provides API endpoints that return invoice data consumed by the [ThinkBridge UI](https://github.com/Prerana-Jadhav/ThinkBridge-UI). It also serves the frontend static files and exposes a Swagger interface for exploring and testing the API directly in the browser.

## Tech Stack

- .NET 8.0
- ASP.NET Core Web API
- Swagger / Swashbuckle

## Project Structure

```
ThinkBridge-API/
├── ThinkBridge.sln
├── .gitignore
└── display_an_invoice/
    ├── display_an_invoice.csproj   # Project configuration and dependencies
    ├── Program.cs                  # App startup, middleware, and routing
    ├── InvoiceController.cs        # GET /api/invoice endpoint
    ├── APIController.cs            # GET /api/data endpoint
    └── init.sql                    # Database schema and seed data
```

## API Endpoints

| Endpoint       | Method | Description                              |
|----------------|--------|------------------------------------------|
| `/api/invoice` | GET    | Returns a list of invoice items          |
| `/api/data`    | GET    | Returns a general data message           |
| `/swagger`     | GET    | Swagger UI for interactive API docs      |

### GET /api/invoice — Sample Response

```json
{
  "items": [
    { "name": "Widget A", "price": 19.99 },
    { "name": "Widget B", "price": 9.99 },
    { "name": "Service Fee", "price": 4.99 }
  ]
}
```

### GET /api/data — Sample Response

```json
{
  "message": "Data fetched"
}
```
<img width="1919" height="1017" alt="Screenshot 2026-04-24 140023" src="https://github.com/user-attachments/assets/e21b27aa-5109-4af7-a8d5-b20fd4a98ab7" />

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/Prerana-Jadhav/ThinkBridge-API.git
cd ThinkBridge-API
```

2. Run the application:

```bash
cd display_an_invoice
dotnet run
```

3. Access the running app:

| URL                              | Description              |
|----------------------------------|--------------------------|
| `http://localhost:5000/swagger`  | Swagger API docs         |
| `http://localhost:5000/index.html` | Invoice UI (if UI files are present) |

## Database

The `init.sql` file contains the schema and seed data for a SQL-based setup:

- `Invoices` table — stores customer invoice records
- `InvoiceItems` table — stores line items linked to invoices

> Note: The current API returns hardcoded data. The SQL schema is provided for reference and future database integration.
