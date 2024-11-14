var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        policy => policy.WithOrigins(
                        "http://localhost:19006",    // React Native
                        "http://localhost:3000",     // React Web
                    )
                    .AllowAnyHeader()
                    .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("Allowall");

if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.Run();