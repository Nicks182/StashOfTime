

namespace SOT_State.Object
{
    public partial class ST_StateObject
    {
        private Dictionary<Guid, StateObject_Column> _Columns { get; set; } = new Dictionary<Guid, StateObject_Column>();
        public Dictionary<Guid, StateObject_Column> Columns 
        { 
            get { return _Columns; }
        }

        public ST_StateObject _Add_Column(StateObject_Column P_Column)
        {
            _Columns.Add(P_Column.Id, P_Column);
            return this;
        }


    }

    public class StateObject_Column
    {
        public Guid Id { get; set; }
        public string Caption { get; set; } = string.Empty;
        public int Order { get; set; } = 0;

        public bool CanView { get; set; } = false;
        public bool IsHidden { get; set; } = false;
        public bool IsDocked { get; set; } = false;
    }
}
