using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Api.Extensions
{
    internal static class SwaggerExtensions
    {
        //internal static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        //{
        //    services.AddSwaggerGen(options =>
        //    {
        //        options.SwaggerDoc("v1", new OpenApiInfo
        //        {
        //            Title = "Rappi Pedia API",
        //            Version = "v1",
        //            Description = "Tool to manage novelties for Google Site with Rappi Pedia",
        //        });
        //        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        //        {
        //            Description = "JWT Authorization header using the Bearer scheme.\n\n" +
        //              "Enter 'Bearer' [space] and then your token in the text input below.\n" +
        //              "Example: 'Bearer 12345abcdef'",
        //            Name = "Authorization",
        //            In = ParameterLocation.Header,
        //            Type = SecuritySchemeType.ApiKey,
        //            Scheme = "Bearer"
        //        });
        //        options.AddSecurityRequirement(new OpenApiSecurityRequirement
        //        {
        //            {
        //                new OpenApiSecurityScheme
        //                {
        //                    Reference = new OpenApiReference
        //                    {
        //                        Type = ReferenceType.SecurityScheme,
        //                        Id = "Bearer"
        //                    }
        //                }, new List<string>()
        //            }
        //        });
        //        var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        //        var commentsFileName = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
        //        var commentsFile = Path.Combine(baseDirectory, commentsFileName);
        //        options.IncludeXmlComments(commentsFile);
        //    });
        //    return services;
        //}

        //internal static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        //{
        //    app.UseS UseSwagger();
        //    app.UseSwaggerUI(c =>
        //    {
        //        c.SwaggerEndpoint("./v1/swagger.json", "PruebaAPI");
        //    });
        //    return app;
        //}
    }
}
