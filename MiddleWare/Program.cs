var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Use(async (Abhi, next) => // await next---> is used to run next 
{
    await Abhi.Response.WriteAsync("hellot this is same\n");
    await next(Abhi);
    // if we write code here then this is also run 
});
app.Run(async (san) =>
{
    await san.Response.WriteAsync("Hello this is second");
});
// Defrent app.Run And app.Use
// app.Run me only one parameter hota hai and app.Use me do parameter hota hai

app.Run();
// Definition of Run() --> Middleware defined using app.Run will never call Subsewquent Middleware it have only one parameter

// Definition of Use()---> The Use() methode places a middleware in the pipeline and allows that middleware to pass
// control to the next item in the pipeline. It have two parameter [(context),next]