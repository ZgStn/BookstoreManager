# BookstoreManager

This WPF application is for managing the inventories of bookstores. We are studying .NET Software Development and have made the app as part of our course in Database Development & Administration. 

## Prerequisites
- .NET 8
- SQL Server

## To run BookstoreManager
1. Clone the repository
3. Restore the database from the backup file **('BookstoreDb.bak')**
4. Configure .NET User Secrets with the following keys:
   
```json
{
  "ServerName": "YourServerName",
  "DatabaseName": "BookstoreDb"
}
```

6. Set **Bookstore.Presentation** as startup project
7. Run the application
