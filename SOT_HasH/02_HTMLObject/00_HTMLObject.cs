

namespace SOT_HasH.Object
{
    public partial class HTMLObject
    {
        private string _Type { get; set; }
        public string Type 
        { 
            get { return _Type; }
        }

        public HTMLObject(string P_Type)
        {
            _Type = P_Type;
        }

        public static HTMLObject Create(string P_Type)
        {
            return new HTMLObject(P_Type);
        }
        
        
    }

    public enum HTMLObject_Icon_Pos
    {
        None,
        IsLeft,
        IsRight,
    }

}
