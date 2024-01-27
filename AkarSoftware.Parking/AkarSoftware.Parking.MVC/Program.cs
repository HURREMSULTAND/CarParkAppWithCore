using AkarSoftware.Parking.Business.Concrete.DependencyResolves.Microsoft;
using AkarSoftware.Parking.MVC;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);


#region Services
builder.Services.AddControllersWithViews();
builder.Services.AddCostumeDependencies();

#endregion

var app = builder.Build();


#region Middlewares

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/exception");
    app.UseStatusCodePagesWithReExecute("/error", "?code={0}");
}


app.UseHsts();

app.UseStaticFiles(); 
//app.UseStaticFiles(new StaticFileOptions
//{
//    RequestPath = "/node_module",
//    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "/node_module"))
//}); 


app.UseRouting();



app.UseEndpoints(endpoint =>
{
    endpoint.MapControllerRoute(name: "default", pattern: "{Area}/{Controller}/{Action=Index}/{id?}", defaults: new { Area = "Landing", Controller = "Home", Action = "Index" });


});


#endregion

app.Run();
