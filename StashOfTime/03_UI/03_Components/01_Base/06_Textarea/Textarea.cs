
using ST_HasH.Object;
using ST_Instruct;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Textarea(HasH_Control_Info P_CompInfo)
        {
            return ST_HTMLObject.Create(HasH_Tag.Textarea)
                .Add_Attribute(HasH_Attribute.Id            , P_CompInfo.GuiId)
                .Add_Attribute(HasH_Attribute.ValidStatus   , P_CompInfo.ValidStatus.ToString())
                .Add_Attribute(HasH_Attribute.Value         , P_CompInfo.Value)
                .Add_Attribute(HasH_Attribute.IsReadonly    , _From_Bool_to_IntString(P_CompInfo.IsReadonly))
                .Add_Attribute(HasH_Attribute.IsHidden      , _From_Bool_to_IntString(P_CompInfo.IsHidden))
                ;
        }

        private string _Textarea_Changed_Event(HasH_Control_Info P_HasH_Control_Info)
        {
            return
                _Changed_Event_Handler(ST_Instruction.Create(ST_Instruction_Type.Value_Changed)
                    .Set_StateId(P_HasH_Control_Info.StateId)
                    .Set_ObjectId(P_HasH_Control_Info.Id)
                    .Add_Action(new ST_Instruction_Action
                    {
                        TargetId = P_HasH_Control_Info.GuiId,
                        Type = ST_Instruction_Action_Type.GetValue
                    })
                );
        }
    }

    
}
