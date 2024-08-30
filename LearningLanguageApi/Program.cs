using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LearningLanguageApp.Models;


//According to Codeium:
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// 1. Add Authentication Services
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.Authority = "https://dev-onepen5hd4rp3vdl.us.auth0.com/";
    options.Audience = "https://lla";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

// 2. Enable authentication middleware
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();



// var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddControllers(); // Register controllers
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// // Configure Entity Framework and register the context
// builder.Services.AddDbContext<LearningLanguageContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// // Configure JWT authentication for Auth0
// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(options =>
//     {
//         options.Authority = $"https://{builder.Configuration["Auth0:Domain"]}/";
//         options.Audience = builder.Configuration["Auth0:Audience"];

//         options.TokenValidationParameters = new TokenValidationParameters
//         {
//             // NameClaimType = "name",
//             // RoleClaimType = "roles"

//             //Codeium
//             NameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name",
//             RoleClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
//         };
//     });

// // Add authorization
// builder.Services.AddAuthorization();

//var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting(); // Enable routing

app.UseAuthentication(); // Add authentication middleware
app.UseAuthorization();  // Add authorization middleware

app.MapControllers(); // Map controllers

app.Run();

