using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args); //runs when project is build.


builder.Services.AddControllersWithViews();  // used for dependency injection  

//services are added here
builder.Services.AddDbContext<PracticeProject.Data.ApplicationDbContext>(options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")  
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.
// all below code is for configuring pipeline (passage for req and res between client and server)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// these are all default middlewares
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



// locahost:2000/ {controller} / {actionmethod} / {id}


//naming convention: 
   // controller -> nameController.cs
   // view -> Views/name/example.cshtml


// Views
// shared folder contains partial views and  master page (main layout page)


// Taghelpers
// used in html like class
// ex: <form asp-controllers="User"> .... </form>


// SQL server
// to start it firt go to 'sql server configure manager' and start mssqlserver
// then open sql server management... and enter server name as '.'.

//Connect to Server:
// in appsettings.json, create connection string.
// create Data folder in project : Data/add/class/ApplicationDbContext.cs
// setup some code in ApplicationDbContext.cs
// next go to Program.cs as add services
// then install nugate packages : .sqlserver .tools
// run in nugate terminal : add-migration AddCategoryToDatabase,   which will create migration folder.
// again run : update-database  (make sure to turn on server)
// we are doing code first as we are creating model first, and creating db based on model
// 


// now creating a categorycontroller - add/mvc empty/ mvc
// add view with same name as actionmethod , razor view, option: use as layout page
// now in _Layout.cshtml write asp-controller... as Category, action as index.

//asp-controller asp... -> tag helpers, used for serverside rendering in html

