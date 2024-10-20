
using ST_HasH.Object;
using ST_Instruct;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Checkbox(HasH_Control_Info P_CompInfo)
        {

            ST_HTMLObject L_HTMLObject = ST_HTMLObject.Create(HasH_Tag.Button)
                .Add_Attribute(HasH_Attribute.Id            , P_CompInfo.GuiId)
                .Add_Attribute(HasH_Attribute.ValidStatus   , P_CompInfo.ValidStatus.ToString())
                .Add_Attribute(HasH_Attribute.Value         , _Checkbox_DefaultValue(P_CompInfo.Value))
                .Add_Attribute(HasH_Attribute.IsReadonly    , _From_Bool_to_IntString(P_CompInfo.IsReadonly))
                .Add_Attribute(HasH_Attribute.IsHidden      , _From_Bool_to_IntString(P_CompInfo.IsHidden))
                
                .Add_Child(_Icon(SH_Components_IconTypes.done).Add_Attribute(HasH_Attribute.Id, "Check"))
                ;

            if (P_CompInfo.EventHandler.EventName is not null)
            {
                L_HTMLObject.Add_Attribute(P_CompInfo.EventHandler.EventName, P_CompInfo.EventHandler.Handler);
            }
            return L_HTMLObject;
        }

        private string _Checkbox_DefaultValue(object P_Value)
        {
            if (P_Value is not null)
            {
                return P_Value.ToString()!;
            }

            return "0";
        }

        private HasH_Control_Info_EventHandler _Checkbox_Changed_Event(HasH_Control_Info P_HasH_Control_Info)
        {
            var L_Handler = new HasH_Control_Info_EventHandler
            {
                EventName = HasH_Attribute.OnClick,
                Handler = _Changed_Event_Handler(ST_Instruction.Create(ST_Instruction_Type.Value_Changed)
                    .Set_StateId(P_HasH_Control_Info.StateId)
                    .Set_ObjectId(P_HasH_Control_Info.Id)
                )
            };

            return L_Handler;
        }


    }


}
