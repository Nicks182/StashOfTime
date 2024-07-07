
using SOT_HasH.Object;

namespace SOT_HasH.Component
{
    public partial class Components
    {
        public HTMLObject _Textbox(HasH_Control_Info P_CompInfo)
        {
            var L_HTML_Object = HTMLObject.Create(HasH_Tag.Input)
                .Add_Attribute(HasH_Attribute.Id, P_CompInfo.GuiId)
                .Add_Attribute(HasH_Attribute.CompType, ((int)HasH_Component_Types.Textbox).ToString())
                .Add_Attribute(HasH_Attribute.ValidStatus, P_CompInfo.ValidStatus.ToString())
                .Add_Attribute(HasH_Attribute.Type, "text")
                .Add_Attribute(HasH_Attribute.Value, P_CompInfo.Text)
                .Add_Attribute(HasH_Attribute.IsReadonly, _FromBool_To_IntString(P_CompInfo.IsReadonly))
                .Add_Attribute(HasH_Attribute.IsHidden, _FromBool_To_IntString(P_CompInfo.IsHidden));

            

            return L_HTML_Object;
        }


    }

    
}
