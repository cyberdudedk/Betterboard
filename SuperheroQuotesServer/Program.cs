var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => 
    options.AddPolicy("AllowAll", builder => 
        builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()
    )
);
var app = builder.Build();
app.UseCors("AllowAll");

app.MapGet("/Quote", () => "Hello World!");

app.Run();
