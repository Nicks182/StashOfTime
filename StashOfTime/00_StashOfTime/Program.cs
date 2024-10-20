using Photino.NET;
using System.Drawing;

namespace _00_StashOfTime
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ST_WebServer.Server
            .Create(new ST_WebServer.ServerOptions
            {
                Args = args,
                PortStart = 8000,
                PortRange = 100,
                WebRootFolder = "wwwroot",
                AllowLocalAccess = true,
            },
            out string L_BaseURL)
            .RunAsync();

            string browserControlInitParams = string.Empty;

            if (PhotinoWindow.IsWindowsPlatform)
            {
                // Windows specific initialization parameters
                browserControlInitParams = "--enable-smooth-scrolling";
            }

            // Create Photino window that will setup our browser window and load our URL...
            PhotinoWindow Wind = new PhotinoWindow()
                .SetChromeless(false)
                .SetUseOsDefaultSize(false)
                .SetUseOsDefaultLocation(false)
                .SetSize(new Size(1200, 800))
                .Center()
                .SetResizable(true)
                .SetTitle("Stash Of Time")
                .SetBrowserControlInitParameters(browserControlInitParams)
                .Load(L_BaseURL);

            Wind.WaitForClose();

        }
    }
}
