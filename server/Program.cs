using server.Data;
using server.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger config
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register to DI container
builder.Services.AddSingleton<Db>();
builder.Services.AddTransient<IUserRepo, UserRepo>();
builder.Services.AddTransient<UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
