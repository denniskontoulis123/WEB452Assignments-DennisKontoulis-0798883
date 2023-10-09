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
2023-10-09 1020AM

starting fresh again. cant get anythign to work.
2023-10-09 1036AM

It looks like I was running it in Dotnet 7. hoping that doing the global.json file adjustment will force it to do what i want.
2023-10-09 1045AM

Attempt 3 has yielded no errors yet; I'm fumbling a lot less now
2023-10-09 1050AM

Now that I'm using proper syntax and not confusing myself with too-recent Stack Overflow and Google articles, I'm not getting errors. wrapped up building the todolist basics. no errors. gonna test now.
2023-10-09 1055AM

Storing urls so I can check later
https://localhost:5001/Sample/Index
and 
https://localhost:5001/Sample/Todolist
And everything shows!! Beautiful!!!!
2023-10-09 1057AM

We fleshed out Smartphone.cs and I made brand, model and OS nullable as last three attempts have been gatekept by the fact that they weren't.  This will allow me to scaffold for my next step using;
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.sqlServer
dotnet tool install --global dotnet-aspnet-codegenerator --version 6
dotnet tool install --global dotnet-ef --version 6
2023-10-09 1110AM


Things seem stable, gonna put together the seeddata.cs file now
2023-10-09 1143AM

SeedData was more of a review of last semester than anything; included a Pixel, the new iPhone, a Samsung and an LG phone.  Going to now start work on the NotFound view.
12023-10-09 1152AM

Made a simple notfound page, it redirects per requirements. Struggling to fill out the other requirements of the step and might leave it as is for the sake of part marks.
12023-10-09 1202PM