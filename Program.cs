using Microsoft.EntityFrameworkCore;
using TestTranslation;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TranslationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConString") ?? throw new InvalidOperationException("Connection is Wrong")));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors("AllowAllOrigins");
app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});


app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(policy =>
           policy.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

app.MapControllers();

app.Run();
