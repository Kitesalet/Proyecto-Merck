using MerckProject;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Utilities;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("pt"),
        new CultureInfo("en"),
        new CultureInfo("es-ar")
    };

    options.DefaultRequestCulture = new RequestCulture("es-ar");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;

});

builder.Services.AddScoped<IEmailSendeer, EmailSender>();
builder.Services.AddScoped<IRegexHelper, RegexHelper>();


DependencyInyector.InyectServices(builder.Services, builder.Configuration);

var app = builder.Build();

app.UseRequestLocalization();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

IWebHostEnvironment env = app.Environment;
Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "../Rotativa/Windows");

app.Run();
