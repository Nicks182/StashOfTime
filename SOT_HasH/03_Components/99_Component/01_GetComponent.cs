
using SOT_HasH.Object;

namespace SOT_HasH.Component
{
    public partial class Components
    {
        public HTMLObject _Get(HasH_Control_Info P_CompInfo)
        {
            switch(P_CompInfo.Type)
            {
                case HasH_Component_Types.Button:
                    return _Button(P_CompInfo);

                case HasH_Component_Types.Label:
                    return _Label(P_CompInfo);

                default:
                    return _Textbox(P_CompInfo);
            }
        }

    }

    
}
