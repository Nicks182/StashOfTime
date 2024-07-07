
using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace SOT_HasH
{
    public class GetIndexPage
    {
        public static EmbeddedFileProvider _Get_FileProvider()
        {
            return new EmbeddedFileProvider(
                assembly: typeof(GetIndexPage).Assembly,
                baseNamespace: "SOT_HasH.wwwroot");
        }
    }
}
