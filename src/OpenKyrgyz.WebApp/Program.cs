using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Verbs;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var mvcBuilder = services.AddRazorPages();

if (builder.Environment.IsDevelopment())
    mvcBuilder.AddRazorRuntimeCompilation();

services.AddResponseCaching();
services.AddSingleton<VerbByTenseConjugator>();
services.AddSingleton<NounDecliner>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseResponseCaching();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();