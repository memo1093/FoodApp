using System;
using foodapp.business.Abstract;
using foodapp.business.Concrete;
using foodapp.data.Abstract;
using foodapp.data.Concrete.EfCore;
using foodapp.webui.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            services.AddDbContext<ApplicationContext>(options=>options.UseMySql( @"server=localhost;port=3306;user=root;password=Mysql-1234;database=FoodDb"));
            services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options=>{
                //password
                options.Password.RequiredLength =6;

                //Lockout
                options.Lockout.MaxFailedAccessAttempts =5;
                options.Lockout.DefaultLockoutTimeSpan =TimeSpan.FromMinutes(10);
                options.Lockout.AllowedForNewUsers= true;

                //User
                // options.User.AllowedUserNameCharacters+="İıÖöÜüŞşÜü";
                options.User.RequireUniqueEmail=true;
                options.SignIn.RequireConfirmedEmail=true;
                // options.SignIn.RequireConfirmedPhoneNumber=true;


            });
            services.ConfigureApplicationCookie(options=>{
                
            });

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

            app.UseAuthentication();
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
