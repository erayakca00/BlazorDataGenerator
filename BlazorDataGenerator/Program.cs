//using BlazorDataGenerator.Controllers;
using BlazorDataGenerator.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);
// crud iþlemleri
// Add services to the container.
builder.Services.AddDbContext<BDGDbContext>(options => options.UseNpgsql(
    builder.Configuration.GetConnectionString("DbConnection")
    ));
builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<DataBuilder>();


var app = builder.Build();

app.MapControllers();


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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
