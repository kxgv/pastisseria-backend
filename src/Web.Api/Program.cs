using Microsoft.EntityFrameworkCore;
using Infraestructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar logging
builder.Services.AddLogging(config =>
{
    config.AddConsole(); // Esto añadirá el log a la consola.
});

// Add services to the container.
builder.Services.AddControllers();

// Obtener la cadena de conexión desde appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddSwaggerGen();

// Registrar el contexto de base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

// Obtener el logger para registrar información
var logger = app.Services.GetRequiredService<ILogger<Program>>();

// Intentar realizar una consulta simple para verificar la conexión
try
{
    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        // Realizar una consulta simple para verificar la conexión (por ejemplo, contar registros en una tabla).
        var isConnected = dbContext.Database.CanConnect();

        if (isConnected)
        {
            logger.LogInformation("Conexión a la base de datos establecida correctamente.");
        }
        else
        {
            logger.LogWarning("No se pudo conectar a la base de datos.");
        }
    }
}
catch (Exception ex)
{
    logger.LogError($"Error al conectar a la base de datos: {ex.Message}");
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
