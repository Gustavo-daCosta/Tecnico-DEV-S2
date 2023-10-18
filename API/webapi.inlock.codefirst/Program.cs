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
        // Valida quem est� solicitando
        ValidateIssuer = true,
        // Valida quem est� recebendo
        ValidateAudience = true,
        // Define se o tempo de expira��o do token ser� validado
        ValidateLifetime = true,
        // Define a forma de criptografia e a valida��o de chave de autentica��o
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("InLock-CodeFirst-DeCria1234567890")),
        // Valida o tempo de expira��o do token
        ClockSkew = TimeSpan.FromMinutes(10),
        // De onde est� vindo
        ValidIssuer = "webapi.inlock_codefirst",
        // At� aonde ir�
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
