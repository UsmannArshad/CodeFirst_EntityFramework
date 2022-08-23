# CodeFirst_EntityFramework
Make model classes and DB_Context classes first and DataBase will be created on its own by using migration Command.
It is difficult to write DB context class so what will we do?
We ll use DB first appraoch to create the classes based on the initial database and then use Code First Approach

# Steps:

# 1)Create a DB,Then run scaffold statement
Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook' Microsoft.EntityFrameworkCore.SqlServer
Result:Our model classes and db context class will be created

# 2)Add Migration
In nugget Console: Add-Migration "<name>"
In PowerShell: dotnet ef migrations add "<name>"
Result:Migration folders will be created containing .cs file having functions "up(creating table)" and "down(dropping table)".The up functions have code for creating
table according to model classes.

# 3)After Commenting Code for Up and deleting down function as we dont want to drop table we will run update command
In Nuget Console: Update-Database -verbose
In Powershell: dotnet ef database update
Result:A table named "Migration History" is created.Database and classes are now synchronized.

Now we can update anything in table like adding marks column.Update in model class.Add migration with name for example marksadded and then run update command.DataBase 
Table will be updated on its own

Note:In case of this error:
No migrations configuration type was found in the assembly 'QuoraForPucit'. (In Visual Studio you can use the Enable-Migrations command from Package Manager Console to add a migrations configuration)
run EntityFrameworkCore\Add-Migration "<name>"
 EntityFrameworkCore\Update-Database -verbose
