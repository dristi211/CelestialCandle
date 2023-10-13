Project name: CelestialCandle
Purpose: Create an unique Candle company’s app using Dot.Net Mvc App (for WEB452 Assingment1)
Author: Dristi Khondkar
Date: 2023-10-05 ISO 8601 12:20

AT 12:30 ASP.NET Core 3.1 application is created for the assigned CANDLE (product) using Visual Studio 2019


Started creating the robust Mvc App for Assingment1. My product was assigned as CANDLE. I will create an unique Candle company product catalogue using  Web Application which will provide Radiance in my customers’ life.

Product Investigation:


At 12:48
oh no why showing this build error message!! click the option OK to run the app with the last build and no update was showing.....then from the Error list saw the File name and line where the error was found and it is an extra curly braces } :)

In the HelloWorldController.cs lets try to change the name of the action method ---public IActionResult Index()method name to Radiance() and check if it works

At 13:06

while trying to change the name of the Index methods name:
An unhandled exception occurred while processing the request.
InvalidOperationException: The view 'Index' was not found. The following locations were searched:
/Views/Home/Index.cshtml
/Views/Shared/Index.cshtml
so change back to Index method 

At 13:10

Add controller and update the Welcome and Index methods in the Controllers/HelloWorldController.cs file. 
Also add the HtmlEncoder.Default.Encode to protect the app from malicious input,

Update the _layout.cshtml page with the following:
Three update done of CelestialCandle to Celestial Candle
The anchor element <a class="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index">CelestialCandle</a> to
<a class="navbar-brand" asp-controller="Home" asp-action="Index">Celestial Candle</a>...

At 13:20

created a loop in the Welcome.cshtml view template that displays "Hello" NumTimes by replacing the contents of Views/HelloWorld/Welcome.cshtml file

At 13:40

Created the View Welcome.cshtml file.Here the ViewData dictionary was used to pass data from the controller to a view.

At 13:57

Models folder > Add > Class. Name the file Candle.cs. created

Update the Candle.cs file with the following code:
using System;
using System.ComponentModel.DataAnnotations;//This was not added first and showing an error that no DataAnnotation was added and then fixed with with the help of intellicence

[DataType(DataType.DateTime)]
[DisplayFormat(DataFormatString = "{yyyy-MM-dd:0}", ApplyFormatInEditMode = true)]// this format for ISO format

The Attributes are the following:

Data type     Attribute Name
  Int          ID              (ID for Candle)
 String        Name             (Name of the Candle)   
 DateTime      ManufactureDate  (Date when the particuler candle manufactured)
 String        Size             (size of the Candle)
 String        Colour           (Colour of the Candle)
 String        Fragrance        (Fragrance of the Candle)
 String        MeltingPoint     (Melting point of the Candle)
 String        Material         (Material that the Candle made with)
 decimal       Price            (Price of the Candle)
  
  At 14:00

 Add the NuGate Package Manager > Package Manager Console (PMC).
instead of PMC we have to do-- Manage NuGate package for solution.....
these will open the NuGet-Solution where we have to Browse
Microsoft.EntityFrameworkCore.SqlServer and not the 7.1 version we have to select 3.1.0 version

At 19:34

opppps an error message appears while doing the scaffolding....
 it says that the ConnectionString cannot be Null...so after spending some time and go back to the Startup -ConfigureService and found the error on the following line code ...I forgot to change the name MvcMovie :( to my project name

 options.UseSqlServer(Configuration.GetConnectionString("CelestialCandleContext")));
 hope it will work now!!
 yes finally its working and created the CRUD pages
Create a Data folder in the main project folder and add Context.cs file in it CelestialCandleContext

update the code 
Next step Register the database context with the following Using statement on the top of  the Startup.cs file
using MvcMovie.Data;
using Microsoft.EntityFrameworkCore;

Although in the MS instruction only UseSqlServer is ask to add but we have to add AddDbContext also

 services.AddDbContext<CelestialCandleContext>(options =>     
 options.UseSqlServer(Configuration.GetConnectionString("CelestialCandleContext")));

 At 19:52 
 
 the Migrations files created 
 In the Package Manager Console (PMC), enter the following commands:

Add-Migration InitialCreate
Update-Database
Which created the Migrations files and Update the database with the Update-Database command

After the Update-Database commend the following warning came in the PMC 

No type was specified for the decimal column 'Price' on entity type 'Candle'. 
This will cause values to be silently truncated if they do not fit in the default precision and scale.
Explicitly specify the SQL server column type that can accommodate all the values using 'HasColumnType()'.

At 22:45

The SeedData class was created with ten(10) product items when seeding the database (Model > SeedData.cs).
The database was created with 8 attributes and characteristics of the product Candle.

The Program.cs file was updated with the using DependencyInjection statement 

using Microsoft.Extensions.DependencyInjection;

Also with the following Using statement

using CelestialCandle.Data;
using CelestialCandle.Models;

At 23:40

While running the app after seedData an error message came

An unhandled exception occurred while processing the request.
FormatException: Input string was not in a correct format.
System.Text.StringBuilder.FormatError()

 in Index.cshtml
 @Html.DisplayFor(modelItem => item.ManufactureDate)

 As I tryed to change the format of the DateTime so it was giving an error....fixed it...keep the original format

 2023-10-06 ISO 9:08

 Resume Working on the  project --first try to add a logo in the header section....
 For that add an Images folder in the wwwroot folder and save a logo png image on the folder
 next open the Views/Shared/_Layout.cshtml file and add the floowing info in the header nav section

 <a class="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index"><img src="~/Images/candle.png"/></a>

 Run the app....the logo is visible but too large to resize the logo image I have to add hight and width attribute...after the src attribute add the hight and width 

 <a class="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index"><img src="~/Images/candle.png" height="150px" width="150px"/></a>
In the wwwroot/css/site.css file added the following code to change the background colour of the pages and font...
 body {
    /* Margin bottom by footer height */
    margin-bottom: 60px;
    background-color: lightgreen;
    font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

although the background colour change but the font style remain the same...need to figure out why...after coming from the classes...

2023-10-07 ISO  18:32
Resume working on the project...
Added a Font folder in the wwwroot and download the google Poppins font family in the folder.
In the site.css added the following code
@font-face{
    font-family:'Poppins-Regular';
    src: url('../Font/Poppins-Regular.ttf') format('truetype');
}

@font-face {
    font-family: 'Poppins-Bold';
    src: url('../Font/Poppins-Bold.ttf') format('truetype');
}
Now I can use the Poppins font family in my header and other font...

At 23:25

Added some bootstrap style in the _Layout page and also in the site.css
Change the nav bar colour...manage to change the font colour, background colour...
need to figure out how to change the padding and size of the font

p{
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
}

.display-4{
    font-family:'Poppins-Regular','Times New Roman', Times, serif;
    font-size:x-large;
    padding-block:auto;
}

2023-10-11 ISO 12:56

Resume working on the Celestial Candle project

I have updated the Display attribute that specifies what to display for the name of a field (in my case "Manufacture Date" instead of "ManufactureDate" and "Melting Point" insted of "MeltingPoint"). The DataType attribute specifies the type of the data (Date), so the time information stored in the field isn't displayed.

The [Column(TypeName = "decimal(18, 2)")] data annotation is required so Entity Framework Core can correctly map Price to currency in the database. 

oppps....forgot to change the field name for "Meltiing Point":)
fixed it...

InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'CelestialCandle.Controllers.CandleMaterialViewModel', but this ViewDataDictionary instance requires a model item of type 'System.Collections.Generic.IEnumerable`1[CelestialCandle.Models.Candle]'.

<form asp-controller="Movies" asp-action="Index" method="get">  the get method forgot to add....lets see if its working...

using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
namespace CelestialCandle.Models
{
    public class CandleMaterialModel
    {
        public List<Candle> Candles { get; set; }
        public SelectList Materials { get; set; }
        public string CandleMaterial { get; set; }
        public string SearchString { get; set; }
    }
}

the Index()method in CandleController.cs updateed with the following code

      // GET: Candles
        // GET: Movies
      public async Task<IActionResult> Index(string searchString)
{
    var candles = from m in _context.Candle
                 select m;

    if (!String.IsNullOrEmpty(searchString))
    {
        candles = candles.Where(s => s.Name.Contains(searchString));
    }

    return View(await candles.ToListAsync());
}

  public async Task<IActionResult> Index(string candleMaterial, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Candle
                                            orderby m.Material
                                            select m.Material;

            var movies = from m in _context.Candle
                         select m;

            if (!string.IsNullOrEmpty(searchString)) //adding search string if there is Null or empty fild
            {
                movies = movies.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(candleMaterial))
            {
                movies = movies.Where(x => x.Material == candleMaterial);
            }

            var candleMaterialVM = new CandleMaterialViewModel
            {
                Materials = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Candles = await movies.ToListAsync()
            };

            return View(candleMaterialVM);
        }
        At 16:34 
        Lambda expression added and chage the code for Candle Size

        OMG after working and find out the probles like 4hours finally it working as the  size 

        Now will work on Add a Rating property to Models/Candle.cs
       at 17:05
       Added the Rating property in the browser view.

      Edit the /Views/Movies/Index.cshtml file and add a Rating field

      At 17:45
      Added  public ActionResult AboutUs() method to the HomeController.cs file

      SqlNullValueException: Data is Null. This method or property cannot be called on Null values