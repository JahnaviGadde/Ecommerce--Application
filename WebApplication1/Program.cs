using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        // Add services to the container.
        builder.Services.AddRazorPages();

        var app = builder.Build();

        var connectionString = builder.Configuration.GetConnectionString("MongoDBConnectionString");
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("myDatabase");

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();


    }
}