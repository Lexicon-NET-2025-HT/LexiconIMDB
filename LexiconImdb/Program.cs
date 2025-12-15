using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LexiconImdb.Data;
using LexiconImdb.Services;
namespace LexiconImdb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<LexiconImdbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("LexiconImdbContext") ?? throw new InvalidOperationException("Connection string 'LexiconImdbContext' not found.")));


            builder.Services.AddScoped<IGenreSelectListService, GenreSelectListService>();

            //builder.Services.AddSingleton => Samma instans under hela applikationens livslängd
            //builder.Services.AddScoped => Samma instans för hela requestet. 
            //builder.Transient => Ny instans varje gång man behöver använda den. 

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
