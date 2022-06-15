using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using MiniCommerce.UI.Services;
using MiniCommerce.UI.Services.Brand;
using MiniCommerce.UI.Services.Category;
using MiniCommerce.UI.Services.Color;
using MiniCommerce.UI.Services.Offer;
using MiniCommerce.UI.Services.Product;
using MiniCommerce.UI.Services.Usage;
using MiniCommerce.UI.Validation;
using System;
using System.IO;

namespace MiniCommerce.UI
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
            //services.AddRazorPages();
            //services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddHttpClient<IAuthService, AuthService>(c =>
            //   c.BaseAddress = new Uri(Configuration["HttClientUrl:MiniCommerceApi"]));

            //services.ConfigureApplicationCookie(options =>
            //{
            //    // Cookie settings
            //    options.Cookie.Name = "Mini Commerce";
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //    options.Cookie.SameSite = SameSiteMode.Strict;
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(1440);
            //    options.SlidingExpiration = true;
            //    options.LoginPath = "/Auth/SignIn";
            //    //options.AccessDeniedPath = "/Auth/SignUp/AccessDenied";
            //    options.SlidingExpiration = true;
            //});

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            //    x.LoginPath = "/Auth/SignIn");

            //services.AddHttpClient("HttClientUrl:MiniCommerceApi");
            //services.AddHttpClient("MiniCommerce", c =>
            //{
            //    c.BaseAddress = new Uri("HttClientUrl:MiniCommerceApi");
            //    //c.DefaultRequestHeaders.Add("Accept", "application/json");
            //});

            //services.AddHttpClient();


            //services.AddControllersWithViews();

            //services.AddControllersWithViews().AddFluentValidation(
            //    a => a.RegisterValidatorsFromAssemblyContaining<AddProductValidation>());

            services.AddAutoMapper(typeof(Startup));

            //services.AddHttpContextAccessor();
            //services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();

            //services.AddControllersWithViews();
            //services.AddUIServices(configuration);

               

            //services.AddFluentValidation(x =>
            //{
            //    x.DisableDataAnnotationsValidation = true;
            //    x.RegisterValidatorsFromAssemblyContaining<AddProductValidation>();
            //});


            services.AddHttpClient<IProductService, ProductService>(c =>
                           c.BaseAddress = new Uri(Configuration["HttClientUrl:API"]));
            
            services.AddHttpClient<ICategoryService, CategoryService>(c =>
                           c.BaseAddress = new Uri(Configuration["HttClientUrl:API"]));

            services.AddHttpClient<IOfferService, OfferService>(c =>
                           c.BaseAddress = new Uri(Configuration["HttClientUrl:API"]));
            
            services.AddHttpClient<IBrandService, BrandService>(c =>
                           c.BaseAddress = new Uri(Configuration["HttClientUrl:API"]));
            
            services.AddHttpClient<IColorService, ColorService>(c =>
                           c.BaseAddress = new Uri(Configuration["HttClientUrl:API"]));
            
            services.AddHttpClient<IUsageService, UsageService>(c =>
                           c.BaseAddress = new Uri(Configuration["HttClientUrl:API"]));

            services.AddHttpClient<IAuthService, AuthService>(c =>
               c.BaseAddress = new Uri(Configuration["HttClientUrl:API"]));

            // 
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddControllersWithViews().AddFluentValidation(
                opt =>
                {
                    opt.RegisterValidatorsFromAssemblyContaining(typeof(Startup));
                });




            services.AddHttpContextAccessor();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); // wwwroot
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),RequestPath = "/modules"
            }); //node_modules static file

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    "blog", 
                //    "{controller}/CategoryProducts={id}", 
                //    new { controller = "Product", action = "CategoryProducts" });
                    

                endpoints.MapControllerRoute(
                    name : "default",
                    pattern :"{controller=Home}/{action=Index}/{id?}");
            });



            ActionResultExtensions.Configure(app.ApplicationServices.GetRequiredService<IHttpContextAccessor>(),
            app.ApplicationServices.GetRequiredService<ITempDataDictionaryFactory>());


        }
    }
}
