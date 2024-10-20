
using ST_HasH.Object;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Screen(string P_HeaderText, ST_HTMLObject P_SubHeader, ST_HTMLObject P_Info, ST_HTMLObject P_Body, ST_HTMLObject P_Footer)
        {
            return _Screen(_Screen_Default_Header(P_HeaderText), P_SubHeader, P_Info, P_Body, P_Footer);
        }

        public ST_HTMLObject _Screen(ST_HTMLObject P_Header, ST_HTMLObject P_SubHeader, ST_HTMLObject P_Info, ST_HTMLObject P_Body, ST_HTMLObject P_Footer)
        {
            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Id, "Div_Screen")
                .Add_Attribute(HasH_Attribute.Class, "Screen")
                
                .Add_Child(_Screen_Get_Child(P_Header, "Screen_Header", true))
                .Add_Child(_Screen_Get_Child(P_SubHeader, "Screen_Sub_Header"))
                .Add_Child(_Screen_Get_Body(P_Info, P_Body))
                .Add_Child(_Screen_Get_Child(P_Footer, "Screen_Footer"));

        }

        private ST_HTMLObject _Screen_Get_Body(ST_HTMLObject P_Info, ST_HTMLObject P_Body)
        {
            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Screen_Body")
                
                .Add_Child(_Screen_Get_Child(P_Info, "Screen_Body_Info"))
                .Add_Child(_Screen_Get_Child(P_Body, "Screen_Body_Content"));
            
        }

        private ST_HTMLObject _Screen_Get_Child(ST_HTMLObject P_HTMLObject, string P_ClassName, bool P_HasBorder = false)
        {
            if(P_HTMLObject is null)
            {
                return null!;
            }

            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, P_ClassName)
                .Add_Attribute(HasH_Attribute.HasBorder, _From_Bool_to_IntString(P_HasBorder))
                
                .Add_Child(P_HTMLObject);

        }

        #region Default Header
        public ST_HTMLObject _Screen_Default_Header(string P_HeaderText)
        {
            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Screen_Header_Default")
                
                .Add_Child(_Screen_Default_Header_Info())
                .Add_Child(_Screen_Default_Header_Text(P_HeaderText));

        }

        private ST_HTMLObject _Screen_Default_Header_Info()
        {
            return _Button(new HasH_Control_Info
                {
                
                })
                .Add_Attribute(HasH_Attribute.Class, "Screen_Header_Default_Info")
                .Add_Attribute(HasH_Attribute.OnClick, "_Screen_Show_Info();")
                
                .Add_Child(_Icon(null, SH_Components_IconTypes.help));

        }

        private ST_HTMLObject _Screen_Default_Header_Text(string P_HeaderText)
        {
            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Screen_Header_Default_Text")
                .Set_InnerText(P_HeaderText);

        }
        #endregion Default Header

    }
}
