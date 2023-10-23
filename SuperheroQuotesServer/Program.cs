var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => 
    options.AddPolicy("AllowAll", builder => 
        builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()
    )
);

builder.Services.AddSingleton(new QuotesService());

var app = builder.Build();
app.UseCors("AllowAll");

app.MapGet("/Quote", (QuotesService quotesService) => quotesService.GetRandomQuote());

app.Run();
