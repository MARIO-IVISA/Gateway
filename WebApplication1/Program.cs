using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
    {
        builder.WithOrigins("") 
               .AllowAnyMethod() 
               .AllowAnyHeader(); 
    });
});


builder.Host.ConfigureAppConfiguration((context, config) =>
{
    config.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
});

builder.Services.AddOcelot(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(
                    s => s.AddPolicy("DefaultPolicy", builder =>
                    {
                        builder.AllowAnyOrigin() //qualquer dominio
                               .AllowAnyMethod() //qualquer método (POST, PUT, DELETE, GET...)
                               .AllowAnyHeader(); //qualquer parametro de cabeçalho
                    }
                        )
                );
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}
app.UseRouting();

app.UseCors("DefaultPolicy");

app.UseOcelot().Wait();

app.UseAuthorization();

app.MapControllers();

app.Run();
