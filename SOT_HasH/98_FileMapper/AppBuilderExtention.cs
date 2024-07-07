
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace SOT_HasH
{
    public static class HasH_BuilderExtensions
    {
        public static IApplicationBuilder Map_HasH_Assets(this IApplicationBuilder app, string localPath)
        {
            app.Map(localPath, builder =>
            {
                var provider = new ManifestEmbeddedFileProvider(
                    assembly: Assembly.GetExecutingAssembly(), "wwwroot");
                builder.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider = provider
                });
            });

            return app;
        }

    }
}
