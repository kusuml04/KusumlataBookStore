﻿2023-03-02
1505
Started Assignment 2 in-class on the lab computer
Setup the ASP.NET MVC w core 1.3(out of support)
HTTPS enabled, individual account authentication ... no Razor...

Create a Repository named as KusumlataBookStore
Reviewed the Areas folder, Controller, Model and Views
AND....

1506....
in startup.cs on the line 33
removed options for default identity
options => options.SignIn.RequireConfirmedAccount = true

1510 ....
Tested the app ... ran it good ....tested links
Action items:
...Modify the Navigation
-Update the copyright from static to dynamic date

Modify the defaul Welcome Page.
Review the route pattern 

*****Stop here my Assignmet 2  ,will continue tomorrow*****

****2023-04-02*****
0305...

continue my Assignment 2      
Clone my repository for Assignmet 2 with github

1537.... 
Rename my Readme.txt

1540 
Rename my Readme.txt to README.txt on Github

1553
Create new README.md       
And update README.md

********Pause Project  2023-03-03 ******

Start working again my project KusumlataBookStore
Rename bootstrap.css to oldbootstrap.css

0238
Then visit Bootwatch.com and go through with some themes
Then select Flatly theme    

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

Pause project at 
1600.........

Start project again at 
1943........

Add dropdown to content managemnet inside _Layout.cshtml

Add new project by sleceting C#


Complete pArt 1    
1526....

1950....
Move data folder inside KusumlataBooks.DataAccess       

Delete Migration folder From KusumlataBooks.DataAccess/Data

Change namespace KusumlataBookStore.Data to namespace KusumlataBookStore.DataAccess.Data in ApplicationDbContext.cs in Line #7   

Delete Class1 from KusumlatBooks.DataAccess,  KusumlatBooks.Models,  KusumlatBooks.Utility

Rename Model folder as ViewModels

Make some changes in HomeController.cs , Error.cshtml and ErrorViewModel.cs

Add SD.cs in KusumlataBooks.DataUtility

Add public statis property in SD.cs file in line #7

Add customer area into Areas Folder

2025....
*** Add this code in Startup.cs   in line 63****    
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

Pause project At   
2023-03-23   
2045...

****** Start Assignment Part #2    ***********      
2023-03-24    
1500...
 
Build project    
 
Update database name in appsettings.json
Change the Default project name to KusumlataBooks.DataAccess

Run command in Package Manager console
**** add-migration AddDefaultIdentityMigration *****
After complete migrations, Update the Databse by run command in colsole  update-databse

1600...
But got errors while update-database          

Severity	Code	Description	Project	File	Line	Suppression State
1. Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	22	Active

2. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	56	Active
3. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	145	Active

4. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	145	Active

5. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	54	Active

6. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	143	Active

1657...
Try to fix errors but did not succeed today   
    
Pause project at 
2023-03-24  
1657...  

Start Project again at           
2023-03-30  
1500...

After so many tries unable to fix errors 
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	58	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	24	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	147	Active
Error	CS1061	'object' does not contain a definition for 'IdentityColumn' and no accessible extension method 'IdentityColumn' accepting a first argument of type 'object' could be found (are you missing a using directive or an assembly reference?)	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	22	Active
Error	CS1061	'object' does not contain a definition for 'IdentityColumn' and no accessible extension method 'IdentityColumn' accepting a first argument of type 'object' could be found (are you missing a using directive or an assembly reference?)	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	56	Active
Error	CS1061	'object' does not contain a definition for 'IdentityColumn' and no accessible extension method 'IdentityColumn' accepting a first argument of type 'object' could be found (are you missing a using directive or an assembly reference?)	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	145	Active

After tha ADD  (public object SqlServerValueGenerationStrategy { get; private set; })   in line 14  inside ApplicationDbContextModelSnapshot.cs and 20230324193704 Designer.cs
but still getting error (Value cannot be null)
Remove the previous changes from ApplicationDbContextModelSnapshot.cs and 20230324193704 Designer.cs
 
2023-03-30    
2000...
I missed the instruction in which i have to install Microsoft.EntityFrameworkCore.Relation and Core.SQLServer packages then review the slides and install 
these packages. *****Finally update-database is successfull*******    
 
2023-03-31  
1102...
Add Category.cs inside KusumlataBooks.Models   
 
Run Command add-migration AddCategoryToDb

using KusumlataBooks.Models; in line first inside ApplicationDbContext.cs
public DbSet<Category> Categories { get; set; }   in line 16

2023-03-31    
1151...
Delete AddCategoryToDb.cs  from migration folder
Add a Repository folder inside KusumlataBooks.DataAccess
Add a IRepository inside Repository folder                

Add a class Repository.cs inside Repository folder
Add ICategoryRepository.cs interface inside Irepository folder and CategoryRepsotory..cs class inside Repository folder

2023-03-31   
1225...
Modify CategoryRepository.cs and ICategoryRepository.cs    

2023-03-31   
1227...
Add inteface named as ISP_Call.cs  inside IRepository.cs   

2023-03-31      
1232...
Add SP_Call.cs inside Repository folder   

2023-03-31   
1239...
Modify the SP_Call.cs file    

2023-03-31   
1242...
Add I UnitOfWork.cs interface inside Irepository folder    

Forget to add migration file name that is why adding now 
Migration files name :     20230324193704_AddDefaultIdentityMigration
    20230331153748_AddCategoryToDb.cs

Facing an error in Startup.cs   
services.AddScoped<UnitOfWork, UnitOfWork>();  in line 36 . 
if i am using <IUnitOfWork> in place of UnitOfWork is is showing me an error that is why uanble to complete Part #2 of Assignment #2
pause project part #2 
at 2023-03-31   
1515 ... 

**********Start again ***************      
2023-03-31        
1835...
Add these two following statements inside UnitOfWork.cs  and this error services.AddScoped<UnitOfWork, UnitOfWork>();   in line 36 is solve.
using KusumlataBooks.DataAccess.Repository.IRepository;
using KusumlataBookStore.DataAccess.Data;                

2023-03-31      
1841...
Error is solved so pause project again  

*************Start Project again remaining part of Part #2**************     
2023-04-06   
1417...

2023-04-06    
1440...
Add CategoryController.cs   inside  Areas/Admin/Controllers folder       

Modify the CategoryController.cs file by adding code

2023-04-06    
1500...
Add Category folder inside Areas/Admin/Views       
Then Add Index.cshtml  inside Category folder

2023-04-06   
1542...
Add <a class="nav-link" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a> in line 29  in _Layout.cshtml   
Undo the above line 217 in _Layout.cshtml

Replecae <a class="dropdown-item" href="#">Action</a>  with <a class="dropdown-item" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a>  in line 39

Facing an error When I am trying to run my project  . My index.cshtml data is not displaying when i am clicking on Category Nav.

2023-04-13     
1424...
Add this in Startup.cs file (in line 72 to 76)          
endpoints.MapAreaControllerRoute(
name: "defaultArea",
areaName: "Admin",
pattern: "{controller=Home}/{action=Index}/{id?}");
endpoints.MapRazorPages();

And now error is slved and category list is showing

Add category.js inside wwwroot folder.

2023-04-13 
1533...
Modify CategoryController.cs     

Add _CreateAndBackToListButton.cshtml inside Shared folder
Add  _EditAndBackToListButton.cshtml inside Shared folder

2023-04-13 
1655...
After that Modify the _CreateAndBackToListButton.cshtml,  _EditAndBackToListButton.cshtml  and Upsert.cshtml  

Facing an error, when i am adding data it is now showing on my Category List.
  
************************* Complete  Assignment Part #2   ***************************   
2023-04-13     
1800...
  
*************************Start Assignment Part #3   **************************   
2023-04-13    
1830...


2023-04-13   
1858...
Add CoverType.cs class inside KusumlataBooks.Models folder      
2023-04-13  
1910...
Add ICoverTypeRepository.cs interface inside IRepository folder   

2023-04-13   
1954...
Modify the code of UnitOfWork.cs and IUnitOfWork.cs  file   
  
2023-04-13    
2025...
Run Command in console add-migration AddCoverTypeToDb  
Add CoverTypeController.cs   inside Areas/Admin/Conroller

2023-04-13   
2043...
Create New folder named as CoverType inside Views folder  and then copy and paste
Index.cshtmla and Upsert.cshtml from Category folder     

Add  <a class="dropdown-item" asp-area="Admin" asp-controller="CoverType" asp-action="Index">CoverType</a> in _Layout.cshtml in line 41

2023-04-13   
2100...
Then Add Cover.js file inside wwwroot/js      
  
Facing an an error when i am trying to run my application when i an clicking on add new category in Covertype nav it directs me to Repository.cs 
and showing an error on line 23

2023-04-14   
2216...
Add a new class Product.cs inside KusumlataBooks.Models project  
Modify the code of Product.cs

2023-04-14  
1038...
Add reference to the new Products piece to the database in the ApplicationDbContext.cs file  

Time stamp for  add CayegoryToDb  20230331153748_AddCategoryToDb.cs
   
Time stamp for addCoverTypeToDb   20230414002243_AddCoverTypeToDb.cs
  
2023-04-14
1046...
Time stamp for addproductToDb  20230414144340_addProductToDb.cs   

Update the product by adding condition of [Required] to Title, ISBN and Author filed

Run the command in console add-migration addValidationToProduct to validate data 
and then update-database 

2023-04-14   
1132...
create interface named as IproductRepository.cs inside Repository folder.   
And then modify the IRepository.cs file

Create a class inside Repository folder named as ProductRepository.cs

Update the code of Productrepository.cs file   
 
2023-04-14  
1207...
Add this line  IProductRepository Product { get; } in IUnitOfWork to add product in  IUnitOfWork   

Add these lines in UnitOfWork.cs to add product in this file
ProductRepository = new ProductRepository(_db);  (line 20)
public IProductRepository Product { get; private set; }  (line 30)

2023-04-14   
1229...
Add ProductController in controller folder   

Add product.js in wwwroot/js folder

2023-04-14  
1338...
Modify the Index.cshtml file by adding entries.
Modify the upsert.cshtml file inside Product folder
and change add my name in this line @model KusumlataBooks.Models.CoverType   

My error is sloved automatically  that i meantioned in line 264 in README.txt  when i continue further steps
but data is still not showing.

i also chnaged my theme from Flatly to Pulse.

********** Complete Assignment 2 Part #3 ************  
2023-04-14     
1342...


2023-04-20
1530...
I added these lines in Startup.cs and now my created entries are showing for
CoverList.
endpoints.MapControllerRoute(
name: "default",
pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");
endpoints.MapRazorPages();

2023-04-21
1537...
Facing erros in further parts, creating entries are not showing for Category, so stoping application here.
But in future i will surely complete this application.

2023-04-21
1543...
Submitting my Assignment #2




 




