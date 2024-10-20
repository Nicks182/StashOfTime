
using ST_Instruct;
using ST_DB.Worker;
using ST_StateManager.Worker;

namespace ST_Core
{
    public partial class ST_Processor(ST_StateWorker P_ST_StateWorker, ST_DbWorker P_ST_DbWorker)
    {
        private readonly ST_StateWorker G_ST_StateWorker = P_ST_StateWorker;
        private readonly ST_DbWorker G_ST_DbWorker = P_ST_DbWorker;
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
