Project name: CelestialCandle
Purpose: Create an unique Candle company’s app using Dot.Net Mvc App (for WEB452 Assingment1)
Author: Dristi Khondkar
Date: 2023-10-05 ISO  12:20

AT 12:30 ASP.NET Core 3.1 application is created for the assigned product using Visual Studio 2019


Started creating the robust Mvc App for Assingment1. My product was assigned as CANDLE. I will create an unique Candle company product catalogue using  Web Application which will provide Radiance in my customers’ life.

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

 At 19:52 the Migrations files created 
 In the Package Manager Console (PMC), enter the following commands:

Add-Migration InitialCreate
Update-Database
Which created the Migrations files and Update the database with the Update-Database command

After the Update-Database commend the following warning came in the PMC 

No type was specified for the decimal column 'Price' on entity type 'Candle'. 
This will cause values to be silently truncated if they do not fit in the default precision and scale.
Explicitly specify the SQL server column type that can accommodate all the values using 'HasColumnType()'.

