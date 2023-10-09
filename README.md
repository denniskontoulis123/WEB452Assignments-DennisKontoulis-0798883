# WEB452Assignments DennisKontoulis 0798883
 Collection of assignments for WEB452

began work on assignment 1, got the MVC webapp rolling, beginning on the sample controller!
2023-10-09 0909AM


strung together the Todolist.cshtml and Index.cshtml.  nothing too complex so far.  might ahve been in my head about whether i can do this competently. getting syntax errors
but my syntax seems completely fine; not really sure what it is asking for truth be told.
2023-10-09 0922AM


got a BUNCH of errors upon making my model for smartphones, then realized it was b/c i used the wrong brackets lol. oops
2023-10-09 0930

Going to take a moment to add all necessary tools now
configured to SQLite via dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet tool install --global dotnet-aspnet-codegenerator --version 6
dotnet tool install --global dotnet-ef --version 6
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6
dotnet add package Microsoft.EntityFrameworkCore.sqlServer --version 6
2023-10-09 0940AM

now going to attempt scaffolding via
dotnet aspnet-codegenerator controller -name PhoneController -m Phone - dc MvcPhoneContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite
referred to Week04 in Blackboard for this line

Initial scaffolding failed, going to attempt to fix errors holding me up
2023-10-09 0940AM

google said to add = null!; to the properties giving me problems.
2023-10-09 0943AM

going tot ry and move away from a dynamic model. hoped it might make life easier but it did not.
2023-10-09 0954AM

deleting everything and starting fresh. cant get rid of these errors.
2023-10-09