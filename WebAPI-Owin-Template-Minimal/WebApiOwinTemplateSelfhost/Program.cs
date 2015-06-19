using Microsoft.Owin.Hosting;
using System;

namespace WebApiOwinTemplateSelfhost
{
    class Program
    {
        static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine("Application started");
                Console.ReadLine();
            }
        }
    }
}
