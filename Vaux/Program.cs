using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Vaux.DbContext;
using Vaux.Repositories;
using Vaux.Repositories.Interface;
using Vaux.Hubs;
using Vaux.ServiceConfiguration;
using Quartz;
using Quartz.AspNetCore;
using Vaux.CronJobs;

namespace Vaux
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var allowClientOrigin = "AllowClientOrigin";
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: allowClientOrigin,
                /*                    builder =>
                                {
                                    builder.AllowAnyOrigin() AllowCredentials() ;
                                });*/
                policy =>
                {
                    policy.WithOrigins(builder.Configuration["JWT:Audience"]!)
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                    policy.WithOrigins("http://127.0.0.1:5500/")
                    .WithMethods("GET", "POST")
                    .AllowCredentials();
                });
            });

            // Add services to the container.
            builder.Services.AddControllers().AddNewtonsoftJson(
                options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                }
            );
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddDbContext<VxDbc>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("VxConnString")));

            builder.Services.AddRepositories();
            builder.Services.AddMapperServices();

            builder.Services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt =>
            {
                opt.SaveToken = true;
                opt.RequireHttpsMetadata = false;
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidAudience = builder.Configuration["JWT:Audience"],
                    ValidIssuer = builder.Configuration["JWT:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]!)),
                    ClockSkew = TimeSpan.Zero
                };
                opt.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];

                        // If the request is for our hub...
                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) &&
                            (path.StartsWithSegments("/vauxchathub")))
                        {
                            // Read the token out of the query string
                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };
            });

            builder.Services.AddSignalR();

            builder.Services.AddCronServices();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(allowClientOrigin);

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.MapHub<VauxChatHub>("/vauxchathub");
            app.Run();
        }
    }
}