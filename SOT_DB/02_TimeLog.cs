using LiteDB;
using System.Diagnostics;

namespace SOT_DB
{
    public class TimeLog
    {
        public string Id { get; set; } = string.Empty;
        public string JobItemId { get; set; } = string.Empty;
        public DateTime DateStart { get; set; }
        public int SecondsLapsed { get; set; } = 0;
        public bool IsTracking { get; set; } = false;
    }

    public partial class ST_DB
    {
        public ILiteCollection<TimeLog> TimeLog_GetAll()
        {
            return this.G_TimeLogs;
        }


        public TimeLog TimeLog_Get(string P_Id)
        {
            return this.G_TimeLogs.FindOne(a => a.Id == P_Id);
        }

        public void TimeLog_Save(TimeLog P_TimeLog)
        {
            if (string.IsNullOrEmpty(P_TimeLog.Id))
            {
                P_TimeLog.Id = Guid.NewGuid().ToString();
                this.G_TimeLogs.Insert(P_TimeLog);
            }
            else
            {
                this.G_TimeLogs.Update(P_TimeLog);
            }
        }

        public void TimeLog_Delete(TimeLog P_TimeLog)
        {
            this.G_TimeLogs.Delete(P_TimeLog.Id);
        }

    }
}
