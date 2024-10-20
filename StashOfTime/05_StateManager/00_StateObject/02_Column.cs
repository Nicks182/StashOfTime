

namespace ST_StateManager.Object
{
    public partial class ST_StateObject
    {
        private Dictionary<Guid, ST_StateObject_Column> _Columns { get; set; } = new Dictionary<Guid, ST_StateObject_Column>();
        public Dictionary<Guid, ST_StateObject_Column> Columns 
        { 
            get { return _Columns; }
        }

        public ST_StateObject _Add_Column(ST_StateObject_Column P_Column)
        {
            if(P_Column.Id == Guid.Empty)
            {
                P_Column.Id = Guid.NewGuid();
            }

            if(P_Column.Order == -1)
            {
                P_Column.Order = _Columns.Count;
            }
            _Columns.Add(P_Column.Id, P_Column);
            return this;
        }

        public ST_StateObject_Column _Get_Column(string P_Name)
        {
            return _Columns.Values.Where(c => c.Name == P_Name).FirstOrDefault()!;
        }
    }

    public class ST_StateObject_Column
    {
        public Guid Id { get; set; }
        public string Caption { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Order { get; set; } = -1;

        public bool CanView { get; set; } = false;
        public bool IsHidden { get; set; } = false;
        public bool IsDocked { get; set; } = false;
    }
}
