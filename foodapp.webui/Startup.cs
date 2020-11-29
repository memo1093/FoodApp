using foodapp.business.Abstract;
using foodapp.business.Concrete;
using foodapp.data.Abstract;
using foodapp.data.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace foodapp.webui
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
            services.AddScoped<IProductRepository,EfCoreProductRepository>();
            services.AddScoped<ICategoryRepository,EfCoreCategoryRepository>();

            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<ICategoryService,CategoryManager>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoint=>
            {
                
                endpoint.MapControllerRoute(
                    name:"adminproductlist",
                    pattern:"admin/categories",
                    defaults:new {controller="Admin",action="CategoryList"}
                );
            });

            app.UseEndpoints(endpoint=>
            {
                
                endpoint.MapControllerRoute(
                    name:"admincreateproduct",
                    pattern:"admin/create-category",
                    defaults:new {controller="Admin",action="Createcategory"}
                );
            });
            app.UseEndpoints(endpoint=>
            {
                
                endpoint.MapControllerRoute(
                    name:"adminproductlist",
                    pattern:"admin/categories/{id?}",
                    defaults:new {controller="Admin",action="Editcategories"}
                );
            });

            app.UseEndpoints(endpoint=>
            {
                
                endpoint.MapControllerRoute(
                    name:"adminproductlist",
                    pattern:"admin/products",
                    defaults:new {controller="Admin",action="ProductList"}
                );
            });
            
            app.UseEndpoints(endpoint=>
            {
                
                endpoint.MapControllerRoute(
                    name:"adminproductlist",
                    pattern:"admin/products/{id?}",
                    defaults:new {controller="Admin",action="Editproduct"}
                );
            });
            app.UseEndpoints(endpoint=>
            {
                
                endpoint.MapControllerRoute(
                    name:"admincreateproduct",
                    pattern:"admin/create-product",
                    defaults:new {controller="Admin",action="Createproduct"}
                );
            });

            app.UseEndpoints(endpoint=>
            {
                
                endpoint.MapControllerRoute(
                    name:"products",
                    pattern:"products",
                    defaults:new {controller="Shop",action="list"}
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
