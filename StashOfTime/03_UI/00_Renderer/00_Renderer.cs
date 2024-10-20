
using ST_Instruct;
using ST_StateManager.Worker;
using ST_HasH.Generator;
using ST_UI.Component;

namespace ST_UI
{
    public partial class ST_Renderer
    {
        private readonly SF_HTMLGenerator G_SF_HTMLGenerator;
        private readonly Components G_Components;
        private readonly ST_StateWorker G_ST_StateWorker;

        public ST_Renderer(ST_StateWorker P_ST_StateWorker)
        {
            G_SF_HTMLGenerator = new SF_HTMLGenerator();
            G_Components = new Components();
            G_ST_StateWorker = P_ST_StateWorker;
        }

        public void _RenderInstruction(ST_Instruction P_ST_Instruction)
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
