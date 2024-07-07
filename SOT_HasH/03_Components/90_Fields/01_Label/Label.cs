
using SOT_HasH.Object;

namespace SOT_HasH.Component
{
    public partial class Components
    {
        public HTMLObject _Label(HasH_Control_Info P_CompInfo)
        {
            var L_HTML_Object = HTMLObject.Create(HasH_Tag.Label)
                .Add_Attribute(HasH_Attribute.Id, P_CompInfo.GuiId)
                .Add_Attribute(HasH_Attribute.CompType, ((int)HasH_Component_Types.Label).ToString())
                .Set_InnerText(P_CompInfo.Text)
                ;
            

            return L_HTML_Object;
        }


    }

    
}
