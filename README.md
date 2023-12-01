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

Dr Majid's code is good but doesn't exactly fit the reqs of the assignment; will still need to upgrade it to fit all requirements.  I think I will use a switch statement- like
in the class example for sorting by clicking the anchors -but essentially for filtering instead.
2023-12-01 11:21AM EST

Nevermind, not gonna od a switch statement, too complicated, will use IF statements
2023-12-01 11:31AM EST

Cooked up a few if statements but my developer and genre values wont show in the actual table for some reason; thought I updated correctly but I guess not?
Date search works but you have to type the date exactly as is.  I'm not sure how to improve it beyond that but it TECHNICALLY fills the requirement.
2023-12-01 11:42AM EST

Still trying to get the columns to show; they are not.
2023-12-01 11:59AM EST

Tried to chang eit via the Edit and it didn't update either. wtf.
2023-12-01 12:01PM EST

I FIXED IT!!! I DROPPED THE TABLE AND RE-ADDED IT!!! 40 MINUTES LATER!! HOLY MOLY!!
2023-12-01 12:24PM EST

starting on step 4 now; added the checkbox and button, going to do the hard coding now.  sorta worked on this in the last class, couldn't figure it out though;
i think it makes the most sense to reference Dr Majid's code on this to some extent. might even have to update the model potentially but will see.
2023-12-01 12:47PM EST

definitely going to update the model; i think it's the best way of doing this. going to give them a boolean value for "IsHidden"; it won't show in the table
but it'll help me tie the checkbox to it in some capacity. i think upon clicking the button it should present games that AREN'T hidden. similar to DeleteSelected 
but only kind of.
2023-12-01 12:49PM EST

managed to put some code together in the controller; did end up updating the model with a new IsHidden boolean; ran the test but it did not work initially. adjusted
Line 26 to exclude hidden games from the list. its working now!!! gotta do the next step so i can see them is all lol.
2023-12-01 1:13PM EST

fumbled around for a bit with naming conventions/making sure actions are doing what they need to and etc. you can now see the hidden games by clicking the anchor in the index. it will return a plain table of the games without any edit/delete/details features + i had to strip the checkbox and much of the 
@Html.DisplayFor(modelItem => item.Score) code because it wasn't displaying ANYTHING initially. presently I am very happy I went to class after doing bad on Assignment 1.
2023-12-01 1:34PM EST