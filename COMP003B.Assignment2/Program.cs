/*
 * Brandon Silvibarr
 * COMP-003B: ASP.NET Core
 *  Instructor: Jonathan Cruz
 *
 * This project will demonstrate the MVC request pipeline, middleware configuration,
 * controllers, views, layout design, and partial views.
 */


namespace COMP003B.Assignment2;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseWelcomePage("/welcome");
        
        //custom middleware
        app.UseMiddleware<RequestTrackerMiddleware>();
        
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();
        
        app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();

        app.Run();
    }
}