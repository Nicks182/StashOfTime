using LiteDB;
using System.Diagnostics;

namespace SOT_DB
{
    public partial class ST_DB
    {
        const string G_App_Name = "StashOfTime";
        const string G_DB_Name = G_App_Name + ".LiteDB";

        private LiteDatabase G_DB;

        private ILiteCollection<JobItem> G_JobItems;
        private ILiteCollection<TimeLog> G_TimeLogs;
        private ILiteCollection<JobNote> G_JobNotes;


        public ST_DB()
        {
            G_DB = new LiteDatabase(GetAppPath());

            this.G_JobItems = G_DB.GetCollection<JobItem>("JobItem");
            this.G_TimeLogs = G_DB.GetCollection<TimeLog>("TimeLog");
            this.G_JobNotes = G_DB.GetCollection<JobNote>("JobNote");
        }

        public void Dispose()
        {
            G_DB.Dispose();
        }

        private string GetAppPath()
        {
            Process L_Process = Process.GetCurrentProcess();
            if (L_Process is not null && L_Process.MainModule is not null)
            {
                return Path.Combine(L_Process.MainModule.FileName.Replace("\\" + G_App_Name + ".exe", "").Replace("\\dotnet.exe", ""), G_DB_Name);
            }

            return "";
        }

        public void ClearDB()
        {
            //this.G_DB_Apps.DeleteAll();
            //this.G_DB_Devices.DeleteAll();
        }
    }
}
