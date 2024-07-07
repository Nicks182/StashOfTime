

namespace SOT_Instruction
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
        Search,
        AddNew_Show,
        AddNew_Save,
    }
}
