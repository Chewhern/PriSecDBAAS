using Microsoft.AspNetCore.DataProtection;
using System.Security.Cryptography.X509Certificates;

var builder = WebApplication.CreateBuilder(args);

builder.Services.
    AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo("/Projects/PriSecDBAPI/DataProtection")).ProtectKeysWithCertificate(
            new X509Certificate2("<Path to PFX Certificate file>", "<PFX Certificate password>"));


// Add services to the container.

builder.Services.AddControllers();

//5002 is a port number, try to avoid the MySQL port, https port and http port
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Listen(System.Net.IPAddress.Parse("0.0.0.0"), 5002, listenOptions =>
    {
        listenOptions.UseHttps("<Path to PFX Certificate file>", "<PFX Certificate password>");
    }
    );
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
