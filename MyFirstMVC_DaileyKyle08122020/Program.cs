//Student:  Kyle Dailey
//Date:  08/12/2020

/**************************************************************************************************************************************************************************************

Description:  This project contains code for a my first MVC application.  Learning the ropes for ASP.NET.  

***************************************************************************************************************************************************************************************

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MyFirstMVC_DaileyKyle08122020
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
