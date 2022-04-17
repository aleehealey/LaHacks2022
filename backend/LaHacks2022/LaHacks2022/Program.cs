using LaHacks2022.Services;
using Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var model = new LaHacksModelContainer("Server=myServerAddress;Database=myDataBase;User Id=admin;Password=d!Y)\M~x6^^D`vuS;Trusted_Connection=True;MultipleActiveResultSets=true;");
builder.Services.AddSingleton(model);
builder.Services.AddSingleton<AuthService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Allow Anyone",
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
