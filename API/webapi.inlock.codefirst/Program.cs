using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "JwtBearer";
    options.DefaultAuthenticateScheme = "JwtBearer";
})
    .AddJwtBearer("J", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        // Valida quem está solicitando
        ValidateIssuer = true,
        // Valida quem está recebendo
        ValidateAudience = true,
        // Define se o tempo de expiração do token será validado
        ValidateLifetime = true,
        // Define a forma de criptografia e a validação de chave de autenticação
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("InLock-CodeFirst-DeCria1234567890")),
        // Valida o tempo de expiração do token
        ClockSkew = TimeSpan.FromMinutes(10),
        // De onde está vindo
        ValidIssuer = "webapi.inlock_codefirst",
        // Até aonde irá
        ValidAudience = "webapi.inlock_codefirst"
    };
});

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
