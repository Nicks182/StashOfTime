

namespace ST_Instruct
{
    public partial class ST_Instruction
    {
        public ST_Instruction_Type InstructionType { get; set; }

        public ST_Instruction Set_Type(ST_Instruction_Type P_Type)
        {
            InstructionType = P_Type;

            return this;
        }
        
    }

    public enum ST_Instruction_Type
    {
        DoNothing,
        Init,
        Item_Edit,
        Item_Save,
        Item_Cancel,
        Item_Check_Changed,
        Value_Changed,
    }
}
