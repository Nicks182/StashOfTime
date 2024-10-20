
using Microsoft.Extensions.FileProviders;

namespace ST_HasH
{
    public class WWWRoot
    {
        public static EmbeddedFileProvider _GetFiles()
        {
            return new EmbeddedFileProvider(
                assembly: typeof(WWWRoot).Assembly,
                baseNamespace: "ST_UI.wwwroot");
        }
    }
}
