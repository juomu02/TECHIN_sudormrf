using Microsoft.EntityFrameworkCore;
using MySavings.Data;
using MySavings.Repositories;
using MySavings.Services;

var builder = WebApplication.CreateBuilder(args);

// SERVICES
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MySavingsDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

// CORS (DEBUG MODE – OPEN)
builder.Services.AddCors(options =>
{
    options.AddPolicy("DevCors", policy =>
    {
        policy
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .WithMethods("GET", "POST", "PUT", "DELETE", "OPTIONS");
    });
});

// DI
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IGoalRepository, GoalRepository>();
builder.Services.AddScoped<IGoalService, GoalService>();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

// Skip HTTPS in development
if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseRouting();

app.UseCors("DevCors");

app.UseAuthorization();

app.MapControllers();



// DB MIGRATION
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<MySavingsDbContext>();
    dbContext.Database.Migrate();
}
app.MapGet("/", () => "API veikia");
app.Run();