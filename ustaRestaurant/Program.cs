using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ustaRestaurant.Data;
using ustaRestaurant.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.23-mysql")
    );
});

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
  //  .AddEntityFrameworkStores<ApplicationDbContext>();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
  //  .AddEntityFrameworkStores<ApplicationDbContext>();
//Service configuration
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IDeliveryService, DeliveryService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
<<<<<<< HEAD
builder.Services.AddScoped<ICommentService, CommentService>();
=======
>>>>>>> 7d92e6c5b14e7a616c52a2209b8e0b891382523f
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//  .AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.AddControllersWithViews();


builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
  .AddEntityFrameworkStores<ApplicationDbContext>()
  .AddRoles<IdentityRole>()
  .AddDefaultUI();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

AppDbInitializer.Seed(app);
AppDbInitializer.SeedUserAndRolesAsync(app).Wait();

app.Run();