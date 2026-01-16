# BookstoreManager

This WPF application is for managing the inventories of bookstores. It has been developed as part of a course in Database Development & Administration. 

## Prerequisites
- .NET 8
- SQL Server

## To run BookstoreManager
1. Clone the repository
3. Restore the database from the backup file **('BookstoreDb.bak')**
4. Configure .NET User Secrets for the **Bookstore.Infrastructure** project with the following keys:
   
```json
{
  "ServerName": "YourServerName",
  "DatabaseName": "BookstoreDb"
}
```

6. Set the **Bookstore.Presentation** project as startup project
7. Run the application

## Application Overview

BookstoreManager is a WPF application developed in C# using Entity Framework Core.
The purpose of the application is to demonstrate CRUD operations against a relational database.

The application allows the user to:

- Select a bookstore

- View the inventory of the selected bookstore

- View a central catalog of available books

- Add books from the central catalog to a bookstore

- Remove books from a bookstore

- Update book quantities and save changes to the database

All data access is handled using Entity Framework Core and a SQL Server database.
