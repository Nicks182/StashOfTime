

namespace SOT_State.Object
{
    public partial class ST_StateObject
    {
        private Dictionary<Guid, StateObject_Field> _Fields { get; set; } = new Dictionary<Guid, StateObject_Field>();
        public Dictionary<Guid, StateObject_Field> Controls
        {
            get { return _Fields; }
        }

        public ST_StateObject _Add_Control(StateObject_Field P_Control)
        {
            _Fields.Add(P_Control.Id, P_Control);
            return this;
        }

        public StateObject_Field _Get_Control(Guid P_Id)
        {
            if (Controls.ContainsKey(P_Id) == false)
            {
                throw new Exception("State Control '" + P_Id + "' not found!");
            }

            return _Fields[P_Id];
        }

    }

    public class StateObject_Field
    {
        public int ValidStatus { get; set; } = 0;
        public string ValidMsg { get; set; } = string.Empty;
        public Guid Id { get; set; }
        public string GuiId { get; set; } = string.Empty;

        public string Caption { get; set; } = String.Empty;
        public string Text { get; set; } = String.Empty;
        private object? _Value { get; set; }
        public object Value
        {
            get
            {
                if (_Value is null)
                {
                    return _Set_ValueDefault();
                }

                return _Value;
            }
            set
            {
                _Value = value;
            }
        }

        public bool IsReadonly { get; set; } = false;
        public bool IsHidden { get; set; } = false;
        public bool CanView { get; set; } = false;

        public StateObject_Type Type { get; set; } = StateObject_Type.Textbox;

        private object _Set_ValueDefault()
        {
            switch (Type)
            {
                case StateObject_Type.ProgressBar:
                case StateObject_Type.Checkbox:
                    return 0;

                default:
                    return string.Empty;
            }
        }
    }
}
