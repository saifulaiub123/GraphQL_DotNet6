using GraphQl_HotChochlete.GraphQL;
using GraphQl_HotChochlete.Models;
using GraphQl_HotChochlete.Services;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;

namespace GraphQl_HotChochlete
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.  
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(opt =>
                {
                    opt.JsonSerializerOptions.PropertyNamingPolicy = null;
                });

            // For Entity Framework  
            services.AddDbContext<DatabaseContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("dbConnection"),
                            options => options.EnableRetryOnFailure())
                );
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<Query>();
            services.AddScoped<Mutation>();
            //services.AddGraphQL(c =>
            //    SchemaBuilder.New().AddServices(c).AddType<GraphQLTypes>().AddQueryType<Query>()
            //        .AddMutationType<Mutation>().Create());
            services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("http://localhost")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });
            });
            services.AddEndpointsApiExplorer();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.  
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions()
                {
                    QueryPath = "/graphql",
                    Path = "/playground"
                });
            }
            if (env.IsProduction())
            {
                app.UseForwardedHeaders(new ForwardedHeadersOptions
                {
                    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
                });
            }
            app.UseRouting();
            app.UseCors();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGraphQL();
            });
            
        }
    }
}
