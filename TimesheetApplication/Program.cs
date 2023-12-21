using TimesheetApplication.DB.WriteAndReadFromJson;
using TimesheetApplication.Repository;
using TimesheetApplication.Services_BusinessLogic.Implementations;
using TimesheetApplication.Services_BusinessLogic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<JsonHelper>();
builder.Services.AddTransient<WriteToJson>();
builder.Services.AddTransient<ReadFromJson>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserServices, UserServices>(); 
builder.Services.AddScoped<IClockEventsRepository, ClockEventsRepository>();
builder.Services.AddScoped<IClockEventServices, ClockEventServices>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
