
using ST_HasH.Object;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Label(HasH_Control_Info P_CompInfo)
        {
            return ST_HTMLObject.Create(HasH_Tag.Output)
                .Add_Attribute(HasH_Attribute.Id, P_CompInfo.GuiId)
                .Add_Attribute(HasH_Attribute.ValidStatus, P_CompInfo.ValidStatus.ToString())
                .Add_Attribute(HasH_Attribute.IsHidden, _From_Bool_to_IntString(P_CompInfo.IsHidden))

                .Set_InnerText(P_CompInfo.Value)
                ;
        }


    }

    
}
