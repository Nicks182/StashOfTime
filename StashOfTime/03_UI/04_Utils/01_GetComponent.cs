
using ST_HasH.Object;
using ST_StateManager;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Get(HasH_Control_Info P_CompInfo)
        {
            switch(P_CompInfo.Type)
            {
                case ST_Object_Type.Label:
                    return _Label(P_CompInfo);

                case ST_Object_Type.Checkbox:
                    return _Checkbox(P_CompInfo);
                            //.Add_Attribute(HasH_Attribute.OnClick, _Checkbox_Changed_Event(P_CompInfo));

                case ST_Object_Type.Button:
                    return _Button(P_CompInfo)
                            .Add_Attribute(HasH_Attribute.OnClick, _Button_Changed_Event(P_CompInfo));

                case ST_Object_Type.Textarea:
                    return _Textarea(P_CompInfo)
                            .Add_Attribute(HasH_Attribute.OnChange, _Textarea_Changed_Event(P_CompInfo));

                default:
                    return _Textbox(P_CompInfo)
                            .Add_Attribute(HasH_Attribute.OnChange, _Textbox_Changed_Event(P_CompInfo));
            }
        }


        
    }

    
}
