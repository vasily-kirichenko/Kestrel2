using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Net.Http.Server;

namespace Kestrel2
{
  public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://0.0.0.0:5000")
                .UseStartup<Startup>()
                .UseWebListener(opts => 
                    opts.Listener.AuthenticationManager.AuthenticationSchemes = AuthenticationSchemes.NTLM)
                .Build();

            host.Run();
        }
    }
}
