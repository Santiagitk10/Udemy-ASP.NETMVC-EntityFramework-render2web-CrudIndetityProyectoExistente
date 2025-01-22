using CrudNet8MVC.Datos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Configuramos la conexi�n a sql ser local db MSSQLLOCAL
builder.Services.AddDbContext<ApplicationDbContext>(opciones => 
            opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql")));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();


//Soporte par identity. IMPORTANTE quitar la confirmaci�n de cuenta por email
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

//Agregar está liena necesaria para el servicio paginas identity razor pages
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}


app.UseStaticFiles();

app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Inicio}/{action=Index}/{id?}");

///Superimportante porque sino no funcionan las rutas del identity
app.MapRazorPages();

app.Run();
