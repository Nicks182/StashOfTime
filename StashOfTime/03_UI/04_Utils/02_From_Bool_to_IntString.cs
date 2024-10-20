

namespace ST_UI.Component
{
    public partial class Components
    {
        public string _From_Bool_to_IntString(bool P_Value)
        {
            switch(P_Value)
            {
                case true:
                    return "1";

                default:
                    return "0";
            }
        }

    }

    
}
