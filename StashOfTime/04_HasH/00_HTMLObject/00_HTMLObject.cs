

namespace ST_HasH.Object
{
    public partial class ST_HTMLObject
    {
        private string _Type { get; set; }
        public string Type 
        { 
            get { return _Type; }
        }

        public ST_HTMLObject(string P_Type)
        {
            _Type = P_Type;
        }

        public static ST_HTMLObject Create(string P_Type)
        {
            return new ST_HTMLObject(P_Type);
        }
        
        
    }

    public enum HTMLObject_Icon_Pos
    {
        None,
        IsLeft,
        IsRight,
    }

}
