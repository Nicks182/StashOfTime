
using SOT_HasH.Object;

namespace SOT_HasH.Component
{
    public partial class Components
    {
        public HTMLObject _Button(HasH_Control_Info P_CompInfo)
        {
            var L_HTML_Object = HTMLObject.Create(HasH_Tag.Button)
                .Add_Attribute(HasH_Attribute.Id, P_CompInfo.GuiId)
                .Add_Attribute(HasH_Attribute.CompType, ((int)HasH_Component_Types.Button).ToString())

                .Add_Attribute(HasH_Attribute.ValidStatus, P_CompInfo.ValidStatus.ToString())
                .Add_Attribute(HasH_Attribute.IsReadonly, _FromBool_To_IntString(P_CompInfo.IsReadonly))
                .Add_Attribute(HasH_Attribute.IsHidden, _FromBool_To_IntString(P_CompInfo.IsHidden))
                .Add_Child(_Button_Caption(P_CompInfo));


            return L_HTML_Object;
        }

        private HTMLObject _Button_Caption(HasH_Control_Info P_CompInfo)
        {
            var L_HTML_Object = HTMLObject.Create(HasH_Tag.Label)
                .Set_InnerText(P_CompInfo.Caption);


            return L_HTML_Object;
        }
    }

    
}
