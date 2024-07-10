# ApnaMakaan

## Overview
**ApnaMakaan** is a full-stack web application built with ASP.NET Core 6 Web API, Angular, and Microsoft SQL Server (MSSQL). It is designed to manage real estate properties, including cities, properties, users, furnishing types, and property types. The application provides functionalities to add, update, delete, and fetch data for these entities.

## Features
- CRUD operations for cities, properties, users, furnishing types, and property types.
- Fetch properties based on sale or rent.
- Fetch properties associated with cities and furnishing types.
- Automatic seeding of initial data into the database.

## Technologies Used
- **Backend**: ASP.NET Core 6 Web API
- **Frontend**: Angular
- **Database**: Microsoft SQL Server (MSSQL)
- **ORM**: Entity Framework Core
- **Automapper**: For object mapping between DTOs and entities

## Project Structure
### Backend (ASP.NET Core 6 Web API)
- **ApnaMakaanAPI.BLL**: Business logic layer containing services and DTOs
- **ApnaMakaanAPI.DAL**: Data access layer containing entity models, repositories, and database context
- **ApnaMakaanAPI.Controllers**: API controllers to handle HTTP requests

### Frontend (Angular)
- **src/app**: Angular components, services, and modules for frontend functionality

## Setup and Installation
### Prerequisites
- .NET 6 SDK
- Node.js and npm
- SQL Server

### Backend Setup
1. **Clone the repository**:
    ```sh
    git clone <repository-url>
    cd ApnaMakaanAPI
    ```

2. **Restore packages**:
    ```sh
    dotnet restore
    ```

3. **Update database connection string**: Modify the connection string in `appsettings.json` to point to your SQL Server instance.

4. **Apply migrations and seed data**:
    ```sh
    dotnet ef database update
    ```

5. **Run the backend**:
    ```sh
    dotnet run
    ```

### Frontend Setup
1. **Navigate to the Angular project**:
    ```sh
    cd ApnaMakaanClient
    ```

2. **Install dependencies**:
    ```sh
    npm install
    ```

3. **Run the frontend**:
    ```sh
    ng serve
    ```

4. Open a web browser and navigate to `http://localhost:4200`.

## API Endpoints
### City Controller
- `GET /api/city` - Get all cities
- `POST /api/city` - Add a new city
- `GET /api/city/{id}` - Get a city by ID
- `DELETE /api/city/{id}` - Delete a city by ID
- `PUT /api/city/{id}` - Update a city by ID
- `GET /api/city/CityWithProperty{id}` - Get a city with all its properties

### Property Controller
- `GET /api/property` - Get all properties
- `POST /api/property` - Add a new property
- `GET /api/property/{id}` - Get a property by ID
- `DELETE /api/property/{id}` - Delete a property by ID
- `PUT /api/property/{id}` - Update a property by ID
- `GET /PropertyForRent` - Get properties for rent
- `GET /PropertyForSale` - Get properties for sale

### User Controller
- `POST /api/user` - Add a new user
- `GET /api/user` - Get all users
- `GET /api/user/{id}` - Get a user by ID
- `DELETE /api/user/{id}` - Delete a user by ID
- `PUT /api/user/{id}` - Update a user by ID

### FurnishingType Controller
- `GET /api/furnishingtype` - Get all furnishing types
- `GET /api/furnishingtype/PropertywithFurnishingType/{id}` - Get properties with a specific furnishing type

### PropertyType Controller
- `GET /api/propertytype` - Get all property types
- `GET /api/propertytype/PropertywithPropoertyType/{id}` - Get properties with a specific property type

## Contributing
Contributions are welcome! Please open an issue or submit a pull request with any improvements or bug fixes.


*Refer Images folder for screenshot of working application functinality*
