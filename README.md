# _Local Business Lookup_
#### _C# ASP .NET Core API project for Epicodus, 2020.08.21_
#### By _**Sara Kane**_

------------
API for a collection of local businesses. The API lists restaurants and shops in town.

## Setup/Installation Requirements
### Required Software
* [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* [MySQL Community Server and MySQL Workbench](https://dev.mysql.com/downloads/)

### Optional Software
* [Postman](https://www.postman.com/downloads/)

### Download Repository

* Clone the GitHub repository by running `git clone https://github.com/sarakane/LocalBusinessLookup.Solution` in the terminal.
  * Or download the ZIP file by clicking on `Code` then `Download ZIP` from this repository.

### Database Setup
* Navigate to the newly created `LocalBusinessLookup.Solution/LocalBusinessLookup directory using either Windows PowerShell, the macOS Terminal, or a Linux Terminal.
  * example: `cd Destop/LocalBusinessLookup.Solution/LocalBusinessLookup`
* In the `appsettings.json` file, change the username `uid` and password `pwd` to match the password that you have set for localhost on port 3306 for your MySQL server.
* In the terminal, run `dotnet restore` and `dotnet build` to build the application.
* Enter `dotnet tool install --global dotnet-ef` to install `dotnet ef` as a global tool.
* Enter `dotnet ef database update` to build the MySQL database from the Migrations folder.

### Launch the API
* Navigate to the newly created `LocalBusinessLookup.Solution/LocalBusinessLookup directory using either Windows PowerShell, the macOS Terminal, or a Linux Terminal.
  * example: `cd Destop/LocalBusinessLookup.Solution/LocalBusinessLookup`
* Run the command `dotnet run` to be able to access the program in Postman or in a browser.
------------
# API Documentation
## Using Swagger Documentation
To explore the Local Business Lookup API with Swagger, launch the project by entering `dotnet run` in the Terminal and input the following URL in your browser `http://localhost:5000`.
## Endpoints
Base URL: 
```
http://localhost:5000
```

### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```
### Example Query
```
http://localhost:5000/api/restaurants/1
```
### Sample JSON Response
```
{
    "restaurantId": 1,
    "name": "Newbergundian Bistro",
    "cuisine": "American(Traditional)",
    "phoneNumber": "971-832-8687",
    "address": "203 Villa Rd",
    "city": "Newberg",
    "state": "OR"
}
```
------------
## Restaurants
Access information on local restaurants.
### HTTP Request
```
GET /api/restaurants
POST /api/restaruants
GET /api/restaurants/{id}
PUT /api/restaurants/{id}
DELETE /api/restaurants/{id}
```
### Example Query
```
http://localhost:5000/api/restaurants/1
```

### Sample JSON Response
```
{
    "restaurantId": 1,
    "name": "Newbergundian Bistro",
    "cuisine": "American(Traditional)",
    "phoneNumber": "971-832-8687",
    "address": "203 Villa Rd",
    "city": "Newberg",
    "state": "OR"
}
```
------------
## Shops
Access information on local shops.
### HTTP Request
```
GET /api/shops
POST /api/shops
GET /api/shops/{id}
PUT /api/shops/{id}
DELETE /api/shops/{id}
```
### Example Query
```
http://localhost:5000/api/shops/1
```

### Sample JSON Response
```
{
    "shopId": 1,
    "name": "Pulp & Circumstance",
    "category": "Cards & Stationery",
    "phoneNumber": "971-264-0563",
    "address": "117 S College St",
    "city": "Newberg",
    "state": "OR"
}
```
------------
## Known Bugs

* No known bugs.

## Technologies Used

* C#
* .NET Core 2.2
* ASP. NET Core
* Entity Famework Core
* MySQL Server 8.0.21
* Visual Studio Code
* Git

### License

*This project is licensed under the MIT license.*

Copyright (c) 2020 **_Sara Kane_**