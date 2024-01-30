# Overview

This is a parpera-code-challenges. There are 3 apis:
1. Get the list of Transaction
2. Update the Transaction Status
3. Create new Transaction

## Getting Started
Run the project on visual studio. The swagger is enabled for now.

### Prerequisites
Packages required:

- Microsoft.AspNetCore.Authentication.JwtBearer
- Microsoft.AspNetCore.OpenApi
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Sqlite


### More Features
- Use ParperaDbContext to add contents to import to table.
- Enable Authorize to make the api secured in the Controller.
- JwtBearer package is installed to add security to api.

#### File and Folders
- ParperaDbContext : The dbContext class to add DB related tables and contents.
- HelperClass : All the class required for api.
- Services : Service class to add functions for api.
- Interface : Interface to add functions to be used in API.

##### Bonus
- Logic for Authentication code can be found in Program.cs file.
- JWT token authorization is enabled which is required. As you have to add token while you try to update transaction.
- To get JWT token, run the Parper/AccessToken api from the swagger. Copy the api code and paste it in the Authorization code box of the update api that is Parper/{id}/updateStatus.
- While model is created the contents have been added to tables for transaction data. You can find it in the ParperaDbCOntext file. 
- Connection string is added but that requires [configuration to be done on running machine]. However, db class is generated inside the project as Parper.db.
