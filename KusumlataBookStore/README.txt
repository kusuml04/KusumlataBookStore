2023-03-02
1505
Started Assignment 2 in-class on the lab computer
Setup the ASP.NET MVC w core 1.3(out of support)
HTTPS enabled, individual account authentication ... no Razor...

Create a Repository named as KusumlataBookStore
Reviewed the Areas folder, Controller, Model and Views
AND....
1506.... in startup.cs on the line 33
removed options for default identity
options => options.SignIn.RequireConfirmedAccount = true

1510 Tested the app ... ran it good ....tested links
Action items:
...Modify the Navigation
-Update the copyright from static to dynamic date

Modify the defaul Welcome Page.
Review the route pattern 

*****Stop here my Assignmet 2  ,will continue tomorrow*****

****2023-04-02*****

continue my Assignment 2      0305
Clone my repository for Assignmet 2 with github

1537  Rename my Readme.txt
1540 Rename my Readme.txt to README.txt on Github

Create new README.md       1553
And update README.md

Pause Project  2023-03-03

Start working again my project KusumlataBookStore
Rename bootstrap.css to oldbootstrap.css

Then visit Bootwatch.com and go through with some themes
Then select Flatly theme     0238

Added downloaded bottstrap.css inside wwwroot/lib/bootstap/css/botstrap.css

Make some changes in _Layout.cshtml, fowllowing changes I made in _Layout.cshtml
1. Rename bootstra.min.css to bootstrap.css
2. change the nav class from navbar-light to navbar dark and bg-white to bg-primary
3. remove text dark from line 23
4. Add  @await RenderSectionAsync to the footer class

Remove references to text-dark in _LoginPartial.cshtml

Added additional stylesheet 
 <link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
    and  script

     <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script src="https://kit.fontawesome.com/e19c476714.js"></script>   

    Pause project at 1600

    Start project again at 1943

    Add dropdown to content managemnet inside _Layout.cshtml

    Add new project by sleceting C#


    Complete pArt 1    1526

    Move data folder inside KusumlataBooks.DataAccess       1950

    Delete Migration folder From KusumlataBooks.DataAccess/Data

    Change namespace KusumlataBookStore.Data to namespace KusumlataBookStore.DataAccess.Data in ApplicationDbContext.cs in Line #7   

    Delete Class1 from KusumlatBooks.DataAccess,  KusumlatBooks.Models,  KusumlatBooks.Utility

    Rename Model folder as ViewModels

    Make some changes in HomeController.cs , Error.cshtml and ErrorViewModel.cs

    Add SD.cs in KusumlataBooks.DataUtility

    Add public statis property in SD.cs file in line #7

    Add customer area into Areas Folder

  *** Add this code in Startup.cs   in line 63****     2025
       endpoints.MapAreaControllerRoute(
        name: "defaultArea",
        areaName: "Customer",
        pattern: "{controller=Home}/{action=Index}/{id?}");

 MoveHomeController.cs inside Areas/Customer/Controllers

 Move Home Folder inside Areas/Customer/Views

 Update HomeController.cs by adding namespace KusumlataBookStore.Area.Customer.Controllers

 Copy and Paste _ViewsImports.cshtml and _Viewstart.cshtml in Customer Areas

 Add  Layout = "~/Views/Shared/_Layout.cshtml"  in _ViewStart.cshtml

  Copy and Paste _ViewsImports.cshtml and _Viewstart.cshtml in Admin Areas

  Delete Controller folder from KusumlataBookStore

  Pause project At   2023-03-23   2045

  ****** Start Assignment Part #2    ***********      2023-03-24     1500
  Build project    
  Update database name in appsettings.json

  Change the Default project name to KusumlataBooks.DataAccess

 Run command in Package Manager console
 add-migration AddDefaultIdentityMigration


    

