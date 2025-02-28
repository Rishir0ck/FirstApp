namespace FirstCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
          
            builder.Services.AddMvc();
          
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
        }
    }
}