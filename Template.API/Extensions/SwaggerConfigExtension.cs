namespace Template.API.Extensions
{
    public static class SwaggerConfigExtension
    {
        /// <summary>
        /// Configures Swagger API documentation and adds it to the specified service collection.
        /// </summary>
        /// <param name="services">The service collection to add Swagger documentation to.</param>
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
           
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Template API",
                    Version = "v1",
                    Description = "Template Service"
                });

                // Token configuration
            });

            services.AddControllers();
        }

        /// <summary>
        /// Configures the Swagger middleware to generate and serve Swagger documentation for the API.
        /// </summary>
        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Template API");
            });
        }
    }
}
