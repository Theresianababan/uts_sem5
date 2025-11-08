using Tokobaju.Services;
using Tokobaju.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();


// Register MongoDB Service
builder.Services.AddSingleton<MongoDBService>();
builder.Services.AddSingleton<SeedData>();

// Add Session untuk login
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // Tambahkan ini untuk session
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Seed admin user and products on startup (only if doesn't exist)
try
{
    var seedData = app.Services.GetRequiredService<SeedData>();
    await seedData.SeedAdminUser();
    await seedData.SeedProducts();
}
catch (Exception ex)
{
    // Log error but don't stop application
    Console.WriteLine($"Error seeding data: {ex.Message}");
}

app.Run();