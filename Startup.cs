using ApiGraphQL.Data;
using ApiGraphQL.Schema;
using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NodaTime;
using System;

namespace ApiGraphQL
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IClock>(SystemClock.Instance);

            services
                .AddEntityFrameworkNpgsql()
                .AddDbContext<AdmContext>();

            services
                .AddDataLoaderRegistry()
                .AddGraphQL(sp =>
                {
                    return SchemaBuilder.New()
                        .AddQueryType<QueryType>()
                        .AddMutationType<MutationType>()
                        .AddType<OffsetDateTime>()
                        .Create();
                });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                MigrateDatabase(app.ApplicationServices);

                app.UseDeveloperExceptionPage();
            }

            app
                .UseGraphQLHttpPost(new HttpPostMiddlewareOptions { Path = "/graphql" })
                .UseGraphQLHttpGetSchema(new HttpGetSchemaMiddlewareOptions { Path = "/graphql/schema" });
        }

        private void MigrateDatabase(IServiceProvider services)
        {
            var scopeFactory = services.GetRequiredService<IServiceScopeFactory>();

            using (var scope = scopeFactory.CreateScope())
            using (var context = scope.ServiceProvider.GetRequiredService<AdmContext>())
            {
                context.Database.Migrate();
            }
        }
    }
}

