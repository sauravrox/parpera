# Overview

This is a parpera-code-challenges. There are 2 apis:
1. Get the list of Transaction
2. Update the Transaction Status

## Getting Started
Run the project on visual studio. Th swagger is enabled for now.

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
- Authentication code has been commented for now in Program.cs file.
- Authorize has been disabled for now to secure API.
- While model is created the contents has been added to tables for transaction data. This is however commented for now. 
- Connection string is added but that requires [configuration to be done on running machine].