# WEB452Assignments DennisKontoulis 0798883
 Collection of assignments for WEB452

starting fresh with a new attempt at assignment 1 prereqs;
set the file up in dotnet 6 per instructions, used the following commands for tools;


    dotnet tool install --global dotnet-aspnet-codegenerator --version 6
    dotnet tool install --global dotnet-ef --version 6
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 6
    dotnet add package Microsoft.EntityFrameworkCore.SQlite --version 6
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6
    dotnet add package Microsoft.EntityFrameworkCore.sqlServer --version 6

Will now be scaffolding 
2023-11-29 19:01PM EST

scaffolded succesfully with
dotnet aspnet-codegenerator controller -name GamesController -m Games -dc MvcGamesContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite
2023-11-29 19:05PM EST

after much wrestling got the intiial DB setup
dotnet ef migrations add InitialCreate
and then
dotnet ef database update
2023-11-29 19:35PM EST


set up not found page, updated controller with it
2023-11-29 19:50PM EST

Began work on Assignment 2; did steps 1 and 2, included a genre and developer property.  Might need to add another one later for the hidden part of the assignment but we'll see.
2023-12-01 11:05AM EST

Added search functionality using Dr Majid's code as reference; surprisingly easy to integrate.  I feel much better about this project than I do the first one.
2023-12-01 11:12AM EST