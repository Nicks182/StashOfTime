
using ST_Instruct;
using ST_DB.Worker;
using ST_StateManager.Worker;
using ST_StateManager.Object;

namespace ST_Core
{
    public partial class ST_Processor
    {
        public void _Init(ST_Instruction P_ST_Instruction)
        {
            ST_StateObject L_ST_StateObject = new ST_StateObject();
            G_ST_StateWorker._Store(L_ST_StateObject);
            P_ST_Instruction.Set_StateId(L_ST_StateObject.StateId);
        }
    }
}
