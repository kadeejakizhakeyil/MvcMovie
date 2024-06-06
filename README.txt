
Kadeeja Kizhakeyil(0856685)
Web app created w/ VS2022 .NET 7


Recreated the ASP .NET MVC Core application
Using .Net 7,no authentication

1325
Ran the program, Confirmed the default works:
https://localhost:7260/
Modified the index.cshtml title to MVC MOVIE by replacing the default title WELCOME
Created README.txt for documentation.
Ran the application again to confirm the changes


1330
I confirmed Part1 of the tutorial is complete, The started with part2
Part2 - Add a Controller

1350
Commented the default index method which is returning to class view()
Then added new index method and changed the content to "This is my default action..."
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld

1400
Added another method called welcome with the content of "This is the Welcome action method..."
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld/welcome

1415
Change the Welcome method to include two parameters(name,numtimes)
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld/welcome?name=kadeeja&numtimes=4

1445
Replace the Welcome method and changed the parameters(name,id)
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld/welcome/0856685?name=kadeeja

2024/17/05
0853
alter welcome method without sending any parameter through URL
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld/welcome/

0858
starting part3
In the HelloWorldController class, replace the Index method and return a view
Added a new folder named HelloWorld under the Views folder.
Added  Razor View - Empty page called Index.cshtml under HelloWorld folder
Replace the contents of the Views/HelloWorld/Index.cshtml
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld/

0922
Open the Views/Shared/_Layout.cshtml file
Replace the MvcMovie to Movie App.
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld

0928
Did check working Privacy link. I Notice how the title on the browser tab displays Privacy Policy - Movie App instead of Privacy Policy - MvcMovie
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/Home/Privacy

0930
Added another link called Images
Added a method called Images in the HomeController
Created a folder called Images under wwwroot folder
Added Razor View - Empty page caleed Images under home folder
Append an image into the view page
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/Home/Images

0940
Open the Views/HelloWorld/Index.cshtml view file.
Change the title and <h2> element
Ran the program, Confirmed the changes works:Browser title,Primary heading,Secondary headings.
The URL to confirm
https://localhost:7260/HelloWorld/

1115
To pass Data from the Controller to the View
change the Welcome method inside the HolloWorldController to add a Message and NumTimes value to the ViewData dictionary.
Create a Welcome view template named Views/HelloWorld/Welcome.cshtml.
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld/welcome?name=kadeeja&numtimes=4

1125
alter welcome method without sending any parameter through URL
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/HelloWorld/welcome

1134
Starting part4
Add a data model class named Movie.cs

1200
Add New Scaffolded Item MVC Controller with views, using Entity Framework(v1.0.0.0).
Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model.
Confirmed the pages and methods created(A movies controller:MoviesController.cs; View Pages: Create, Delete, Details, Edit, and Index; database context class: Data/MvcMovieContext.cs)


2024-05-21
1537
Add Migrations feature to create the database
Examine the generated database connection string in appsettings.json file
Examine the Migrations/20240521193631_InitialCreate migration file:
Confirmed with table creation called Movie.
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/movies/
https://localhost:7260/Movies/Create
https://localhost:7260/Movies/Edit/1
https://localhost:7260/Movies/Delete/6
https://localhost:7260/Movies/Details/1

2024-05-23
1440
Starting part5
Examine the database by opening SQL Server Object Explorer (SSOX).
Create a new class named SeedData in movie model
Replace the contents of Program.cs
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/movies/

1500
Starting part6
add a blank space in Release data heading by editing Movie model class called Movie
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/movies/

2024-05-24
2353
Checked client-side validation rules on the fields. 
submited the form with empty fields.
An error message is displayed and the form isn't posted

2024-05-25
0000
Starting part7
Adding search capability to the Index action method that lets to search movies by name.
Update the Index method found inside Controllers/MoviesController.cs
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/movies/index?searchString=Ghost

0014
Change the search parameter to id and change all occurrences of searchString to id.
The updated Index method inside Controllers/MoviesController.cs with id parameter
https://localhost:7260/movies/index/ghost

0234
add UI elements to help filter movies.
Added the <form> markup in the Views/Movies/Index.cshtml file
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/movies/

0257
Filter form submited with HTTP GET method
Observe the changes in the URL
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/Movies?SearchString=ghost
did understood difference between both GET and POST method

0306
Add Search by genre
Added new class called MovieGenreViewModel in to the Movie Model
Change the Index method in MoviesController.cs to perform the filter with title and genre
Add search by genre to the Index view
Ran the program, Confirmed the changes works:
The URL to confirm
search movie title
https://localhost:7260/Movies?MovieGenre=&SearchString=ghost
search for genre
https://localhost:7260/Movies?MovieGenre=Western&SearchString=
search for both name and genre
https://localhost:7260/Movies?MovieGenre=Comedy&SearchString=ghost

0336
Starting part8
Add a new field called Rating to the Movie model.
In MoviesController.cs, update the [Bind] attribute for both the Create and Edit action methods to include the Rating property
Update the view templates in order to display, create, and edit the new Rating property 
Update the SeedData class inside the Movie model, so that it provides a value for the new column
Used Migrations tool to update the database schema for the new field.
Examine the Migrations/20240525080450_Rating.cs for the Rating field
Ran the program, Confirmed the changes works:
The URL to confirm
Display index page for the Updation of Rating field
https://localhost:7260/Movies
Display Create page for the Updation of Rating field
https://localhost:7260/Movies/Create
Display Edit page for the Updation of Rating field
https://localhost:7260/Movies/Edit/7
Display deatils page for the Updation of Rating 
https://localhost:7260/Movies/Details/7

0422
Starting part9
Update the Movie class to built-in validation attributes Required, StringLength, RegularExpression, Range and the DataType formatting attribute.
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/Movies/Create
https://localhost:7260/Movies/Edit/7

2139
Starting part10
Examined and verified all the steps

2024-06-06
1430
Created account github repository
Get credentials for the github Account
https://github.com/kadeejakizhakeyil/MvcMovie.git

1435
Cretaed clone repository for MVCMovie which is created in local system


1446
I edited the seeddata file to add 5 new items
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7260/Movies

1450
Committed the file which is updated


1518
Done With MVCMovie
Total duration to complete this MVCMovie application: 4 Hours

















		















