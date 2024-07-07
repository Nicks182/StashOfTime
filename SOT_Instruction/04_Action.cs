

namespace SOT_Instruction
{
    public partial class ST_Instruction
    {
        public List<ST_Instruction_Action> Actions { get; set; } = [];


        public ST_Instruction Add_Action(ST_Instruction_Action P_Action)
        {
            Actions.Add(P_Action);

            return this;
        }

        public ST_Instruction Add_Actions(List<ST_Instruction_Action> P_Actions)
        {
            Actions.AddRange(P_Actions);

            return this;
        }

        public ST_Instruction Add_Action(string P_TargetId, string P_Value, ST_Instruction_Action_Type P_Type)
        {
            Actions.Add(new ST_Instruction_Action
            {
                TargetId = P_TargetId,
                Type = P_Type,
                Value = P_Value
            });

            return this;
        }
    }
    public class ST_Instruction_Action
    {
        public string TargetId { get; set; } = string.Empty;
        public string Value { get; set; } = "";
        public ST_Instruction_Action_Type Type { get; set; }
    }

    public enum ST_Instruction_Action_Type
    {
        DoNothing = 0,
        GetValue = 1,
        SetValue = 2,
        GetAttribute = 3,
        SetAttribute = 4,
        GetLocalStore = 5,
        SetLocalStore = 6,
        SetFocus = 7,
        SetHighlight = 8,
        SetHidden = 9,
        SetModalState = 10,
    }

}
