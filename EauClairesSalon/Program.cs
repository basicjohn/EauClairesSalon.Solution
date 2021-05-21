using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using EauClairesSalon.Models;
using System.Collections.Generic;


namespace EauClairesSalon
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}