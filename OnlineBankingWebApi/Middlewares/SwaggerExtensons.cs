using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace OnlineBankingWebApi.Middlewares
{
    public static class SwaggerExtensons
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.OperationFilter<SecurityRequirementsOperationFilter>();
                
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Swift Bank APIs",
                    Version = "v1",
                    Description = "This is the directory of the linkt apis for swift bank financial service",
                    Contact = new OpenApiContact
                    {
                        Name = "Swift Bank internet banking.",
                        Url = new Uri("https://swiftbank.com")
                    }
                });

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = """Enter your valid token in the text input below. Example: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpJ9" """,
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()

                    }
                });
            });
        }
    }
}