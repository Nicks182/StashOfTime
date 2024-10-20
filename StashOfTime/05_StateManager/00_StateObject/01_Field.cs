

namespace ST_StateManager.Object
{
    public partial class ST_StateObject
    {
        private Dictionary<Guid, ST_StateObject_Field> _Fields { get; set; } = new Dictionary<Guid, ST_StateObject_Field>();
        public Dictionary<Guid, ST_StateObject_Field> Fields
        {
            get { return _Fields; }
        }

        public ST_StateObject _Add_Control(ST_StateObject_Field P_Control)
        {
            _Fields.Add(P_Control.Id, P_Control);
            return this;
        }

        public ST_StateObject_Field _Get_Control(Guid P_Id)
        {
            if (Fields.ContainsKey(P_Id) == false)
            {
                throw new Exception("State Control '" + P_Id + "' not found!");
            }

            return _Fields[P_Id];
        }

    }

    public class ST_StateObject_Field
    {
        
        public Guid Id { get; set; }
        private string _GuiId { get; set; } = string.Empty;
        public string GuiId { get => _Get_GuidId(); }
        private string _Name { get; set; } = string.Empty;
        /// <summary>
        /// Will automatically remove any white spaces in string when set.
        /// </summary>
        public string Name { get => _Name; set => _Name = value.Replace(" ", ""); }

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
                if (_Value is null && value is not null && _Value != value)
                {
                    HasChanged = true;
                }
                _Value = value;
            }
        }
        public int ValidStatus { get; set; } = 0;
        public string ValidMsg { get; set; } = string.Empty;
        public bool HasChanged { get; set; }

        public bool IsReadonly { get; set; } = false;
        public bool IsHidden { get; set; } = false;
        public bool CanView { get; set; } = false;

        public ST_Object_Type Type { get; set; } = ST_Object_Type.Textbox;

        private string _Get_GuidId()
        {
            if(string.IsNullOrEmpty(Name) == true)
            {
                throw new Exception("Name property of State Object Field must be set!");
            }

            if(string.IsNullOrEmpty(_GuiId) == true)
            {
                _GuiId = Name + "_" + Id.ToString().Replace("-", "_");
            }

            return _GuiId;
        }

        private object _Set_ValueDefault()
        {
            switch (Type)
            {
                case ST_Object_Type.Progressbar:
                case ST_Object_Type.Checkbox:
                    return 0;

                default:
                    return string.Empty;
            }
        }
    }
}
