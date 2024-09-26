var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // This Services is use for Routing in MVC
var app = builder.Build();

//app.MapGet("/", () => " This is Routing ");

app.MapDefaultControllerRoute(); // This methode is only use HomeController's Index action method

//app.MapAreaControllerRoute(
//    name: "Defult",
//    pattern: "{controller=Home}/{action=Index}/{id?}"
//    );
app.Run();

// ( Routing = URL + HTTP METHODES )
// url = https://localhost:7204/  in inclued httpmethod
// There are two typs of Routnig 
// 1. Convention Based Routing
// 2. Attribute Based Routing

// 1. Convention Based Routing
