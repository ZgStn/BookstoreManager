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
