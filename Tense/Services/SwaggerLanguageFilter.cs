using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;

namespace Tense.Rql.Services
{
    /// <summary>
    /// Swagger Language Filter
    /// </summary>
    public class SwaggerLanguageFilter : IOperationFilter
    {
        /// <summary>
        /// Applies the Swagger Language Filter
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="context"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Accept-Language",
                In = ParameterLocation.Header,
                Description = "Accept-Language",
                Schema = new OpenApiSchema() { Type = "string" },
                Required = false // set to false if this is optional
            });
        }
    }
}
