
using ST_HasH.Object;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Field_Item(HasH_Control_Info P_HasH_Control_Info)
        {
            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Field_Item")
                .Add_Child(_Form_Item_Caption(P_HasH_Control_Info))
                .Add_Child(_Form_Item_Input(P_HasH_Control_Info))
                ;
        }

        private ST_HTMLObject _Form_Item_Caption(HasH_Control_Info P_HasH_Control_Info)
        {
            return ST_HTMLObject.Create(HasH_Tag.Label)
                .Add_Attribute("Title", P_HasH_Control_Info.Caption)
                .Add_Attribute("IsCaption", "1")
                .Set_InnerText(P_HasH_Control_Info.Caption)
                ;
        }

        public ST_HTMLObject _Form_Item_Input(HasH_Control_Info P_HasH_Control_Info)
        {
            return _Get(P_HasH_Control_Info).Add_Attribute("IsField", "1");
        }

    }

}
