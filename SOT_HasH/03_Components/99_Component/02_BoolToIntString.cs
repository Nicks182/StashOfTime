

namespace SOT_HasH.Component
{
    public partial class Components
    {
        public string _FromBool_To_IntString(bool P_Value)
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
