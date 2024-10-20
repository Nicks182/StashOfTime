
using ST_HasH.Object;

namespace ST_UI.Component
{
    public partial class Components
    {

        public string G_ModalHolderId = "Div_ModalHolder";

        public ST_HTMLObject _Modal(HasH_Modal_Info P_HasH_Modal_Info)
        {
            ST_HTMLObject L_HTML_Object = ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Id, P_HasH_Modal_Info.Id)
                .Add_Attribute(HasH_Attribute.Class, "Modal")
                .Add_Attribute(HasH_Attribute.IsHidden, _From_Bool_to_IntString(P_HasH_Modal_Info.IsHidden))

                .Add_Child(_Modal_Mask(P_HasH_Modal_Info))
                .Add_Child(_Modal_Content(P_HasH_Modal_Info));

            

            return L_HTML_Object;
        }

        private ST_HTMLObject _Modal_Mask(HasH_Modal_Info P_HasH_Modal_Info)
        {
            ST_HTMLObject L_HTML_Object = ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Modal_Mask")
                .Add_Attribute(HasH_Attribute.OnClick, _Model_GetMaskClickEvent(P_HasH_Modal_Info))
                ;

            return L_HTML_Object;
        }

        private string _Model_GetMaskClickEvent(HasH_Modal_Info P_HasH_Modal_Info)
        {
            if (P_HasH_Modal_Info.CanCloseOnMask == true)
            {
                return "_Modal_Hide('" + P_HasH_Modal_Info.Id + "')";
            }

            return "";
        }

        private ST_HTMLObject _Modal_Content(HasH_Modal_Info P_HasH_Modal_Info)
        {
            ST_HTMLObject L_HTML_Object = ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Modal_Content")

                .Add_Child(P_HasH_Modal_Info.Content);

            return L_HTML_Object;
        }

        

    }

    
}
