using FirstApp.Models;

namespace FirstCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
          
            builder.Services.AddMvc();
            //Application services
            builder.Services.AddSingleton<IStudentRepository,StudentRepository>();
          
            var app = builder.Build();
            
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            // if(app.Environment.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }
            

            // app.MapGet("/", async context =>
            // {
            //     int Number1 = 10, Number2 = 2;
            //     int Result = Number1 / Number2; //This statement will throw Runtime Exception
            //     await context.Response.WriteAsync($"Result : {Result}");
            // });

            //This will Run the Application
            app.Run();

            //Add application services.
            // builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), new StudentRepository()));//by default singleton
            // builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository),ServiceLifetime.Singleton));//singleton
            // builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository),ServiceLifetime.Transient));//Transient
            // builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository),ServiceLifetime.Scoped));//Scoped
            



        }
    }
}