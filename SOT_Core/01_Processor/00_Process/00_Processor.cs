
using SOT_DB;
using SOT_Instruction;

namespace SOT_Core
{
    public class ST_Processor(ST_DB P_ST_DB)
    {
        private readonly ST_DB G_ST_DB = P_ST_DB;

        public void _ProcessInstruction(ST_Instruction P_ST_Instruction)
        {
            switch(P_ST_Instruction.InstructionType)
            {
                case ST_Instruction_Type.Init:
                    break;
            }
        }
    }
}
