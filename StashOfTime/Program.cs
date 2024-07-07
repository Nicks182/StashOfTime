
using Photino.NET;
using System.Drawing;

namespace StashOfTime
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            SOT_WebServer.Server
            .Create(new SOT_WebServer.ServerOptions
            {
                Args = args,
                PortStart = 8000,
                PortRange = 100,
                WebRootFolder = "wwwroot",
                AllowLocalAccess = true,
            },
            out string L_BaseURL)
            .RunAsync();

            // Create Photino window that will setup our browser window and load out URL...
            PhotinoWindow Wind = new PhotinoWindow()
                .SetChromeless(false)
                .SetUseOsDefaultSize(false)
                .SetUseOsDefaultLocation(false)
                .SetSize(new Size(1200, 800))
                .Center()
                .SetResizable(true)
                .ClearBrowserAutoFill()
                .Load(L_BaseURL);

            Wind.WaitForClose();

        }
    }
}
