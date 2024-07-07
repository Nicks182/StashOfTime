using LiteDB;
using System.Diagnostics;

namespace SOT_DB
{
    public class JobNote
    {
        public string Id { get; set; } = string.Empty;
        public string JobItemId { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }

        public string Text { get; set; } = string.Empty;
    }

    public partial class ST_DB
    {
        public ILiteCollection<JobNote> JobNote_GetAll()
        {
            return this.G_JobNotes;
        }


        public JobNote JobNote_Get(string P_Id)
        {
            return this.G_JobNotes.FindOne(a => a.Id == P_Id);
        }

        public void JobNote_Save(JobNote P_JobNote)
        {
            if (string.IsNullOrEmpty(P_JobNote.Id))
            {
                P_JobNote.Id = Guid.NewGuid().ToString();
                this.G_JobNotes.Insert(P_JobNote);
            }
            else
            {
                this.G_JobNotes.Update(P_JobNote);
            }
        }

        public void JobNote_Delete(JobNote P_JobNote)
        {
            this.G_JobNotes.Delete(P_JobNote.Id);
        }

    }
}
