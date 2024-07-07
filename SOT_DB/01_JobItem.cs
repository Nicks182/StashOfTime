using LiteDB;
using System.Diagnostics;

namespace SOT_DB
{
    public class JobItem
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }

    public partial class ST_DB
    {
        public ILiteCollection<JobItem> JobItem_GetAll()
        {
            return this.G_JobItems;
        }


        public JobItem JobItem_Get(string P_Id)
        {
            return this.G_JobItems.FindOne(a => a.Id == P_Id);
        }

        public void JobItem_Save(JobItem P_JobItem)
        {
            if (string.IsNullOrEmpty(P_JobItem.Id))
            {
                P_JobItem.Id = Guid.NewGuid().ToString();
                this.G_JobItems.Insert(P_JobItem);
            }
            else
            {
                this.G_JobItems.Update(P_JobItem);
            }
        }

        public void JobItem_Delete(JobItem P_JobItem)
        {
            this.G_JobItems.Delete(P_JobItem.Id);
        }

    }
}
