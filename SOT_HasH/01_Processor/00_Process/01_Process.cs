
using SOT_Instruction;

namespace SOT_HasH
{
    public partial class ST_Processor
    {
        public void _ProcessInstruction(ST_Instruction P_ST_Instruction)
        {
            switch(P_ST_Instruction.InstructionType)
            {
                case ST_Instruction_Type.Init:
                    _Init(P_ST_Instruction);
                    break;
            }
        }
    }
}
