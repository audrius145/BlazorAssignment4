using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3API.Model;
using Assignment3API.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Assignment3API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (Assignment4DBContext todoContext = new Assignment4DBContext())
            {
                if (!todoContext.Users.Any())
                {
                    Seed(todoContext);
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });


        public static void Seed(Assignment4DBContext ctx)
        {
            User user = new User
            {
                Password = "123456",
                Role = "user",
                UserName = "filipina"
            };

            User user1 = new User
            {

                Password = "123456",
                Role = "admin",
                UserName = "eva"
            };


            User user2 = new User
            {
                Password = "1234",
                Role = "collector",
                UserName = "levente"
            };
            ctx.Add(user);
            ctx.Add(user1);
            ctx.Add(user2);
            ctx.SaveChanges();
        }
    }
}