
using System.Net.NetworkInformation;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

using ST_HasH;
using ST_DB.Worker;
using ST_StateManager.Worker;

namespace ST_WebServer
{
    public class Server
    {
        public static WebApplication Create(ServerOptions P_ServerOptions, out string O_BaseUrl)
        {
            var builder = WebApplication
            .CreateBuilder(new WebApplicationOptions()
            {
                Args = P_ServerOptions.Args,
            });

            builder.Services.AddSignalR().AddJsonProtocol(options =>
            {
                options.PayloadSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter(null, true));
                options.PayloadSerializerOptions.PropertyNamingPolicy = null;
                options.PayloadSerializerOptions.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            });

            builder.Services.AddSingleton<ST_StateWorker>();
            builder.Services.AddSingleton<ST_DbWorker>();

            int port = P_ServerOptions.PortStart;

            // Try ports until available port is found
            while (IPGlobalProperties
                .GetIPGlobalProperties()
                .GetActiveTcpListeners()
                .Any(x => x.Port == port))
            {
                if (port > P_ServerOptions.PortStart + P_ServerOptions.PortRange)
                {
                    throw new SystemException($"Couldn't find open port within range {P_ServerOptions.PortStart} - {P_ServerOptions.PortStart + P_ServerOptions.PortRange}.");
                }
                port++;
            }

            O_BaseUrl = $"http://localhost:{port}";

            if (P_ServerOptions.AllowLocalAccess)
            {
                builder.WebHost.UseUrls($"http://*:{port}");
            }
            else
            {
                builder.WebHost.UseUrls(O_BaseUrl);
            }

            WebApplication app = builder.Build();

            EmbeddedFileProvider fp = WWWRoot._GetFiles();

            app.UseDefaultFiles(new DefaultFilesOptions { FileProvider = fp });

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = fp,
            });

            app.MapHub<ServerHub>("ServerHub");

            return app;
        }
    }

    public class ServerOptions
    {
        public string[] Args { get; set; } = [];
        public int PortStart { get; set; }
        public int PortRange { get; set; }
        public string WebRootFolder { get; set; } = string.Empty;

        public bool AllowLocalAccess { get; set; }
    }
}
