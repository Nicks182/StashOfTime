
using ST_HasH.Object;
using ST_Instruct;
using ST_StateManager.Object;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Home(ST_StateObject P_ST_StateObject)
        {
            var L_HTML_Object = _Screen(_Home_Header(), _Home_SubHeader(), null!, _Home_Body(P_ST_StateObject), null!);

            return L_HTML_Object;
        }


        private ST_HTMLObject _Home_Header()
        {
            var L_HTML_Object = ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Id, "")
                .Add_Attribute(HasH_Attribute.Class, "Home")
                ;

            L_HTML_Object.Add_Child(_Label(new HasH_Control_Info
            {
                Value = "This is HOME!!"
            }));

            return L_HTML_Object;
        }

        private ST_HTMLObject _Home_SubHeader()
        {
            var L_HTML_Object = ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Id, "")
                .Add_Attribute(HasH_Attribute.Class, "Home_SubHeader")
                ;

            L_HTML_Object.Add_Child(_Home_SubHeader_EditItem());

            return L_HTML_Object;
        }

        private ST_HTMLObject _Home_SubHeader_EditItem()
        {
            var L_HTML_Object = _Button(new HasH_Control_Info
            {
                Caption = "New",
            })
            .Add_Attribute(HasH_Attribute.OnClick, _Changed_Event_Handler(ST_Instruction.Create(ST_Instruction_Type.Item_Edit)));
            return L_HTML_Object;
        }

        private ST_HTMLObject _Home_Body(ST_StateObject P_ST_StateObject)
        {
            var L_HTML_Object = ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Id, "Home_Body")
                .Add_Attribute(HasH_Attribute.Class, "Home")
                ;

            //L_HTML_Object.Add_Children(_WorkItems(P_ST_StateObject));

            L_HTML_Object.Set_InnerText("This is home");

            return L_HTML_Object;
        }

    }

}
