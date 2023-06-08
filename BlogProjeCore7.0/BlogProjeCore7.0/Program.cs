using BlogProjeCore7._0.Data;
//using Microsoft.AspNetCore.Authentication.Cookies;//Admin Authentication ile Güvenlik Ayarlarý


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DatabaseContext>();

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>  //Admin Authentication ile Güvenlik Ayarlarý
//{
//    x.LoginPath = "/Login";
//    x.Cookie.Name = "AdminLogin";
//});
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

app.UseRouting();

//app.UseAuthentication();//Admin Authentication ile Güvenlik Ayarlarý,sýralama bu uste olacak herzaman bunun UseAuthorization üstünde,yetkilendirrme

app.UseAuthorization();

app.MapControllerRoute(
           name: "admin",
           pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
         );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
