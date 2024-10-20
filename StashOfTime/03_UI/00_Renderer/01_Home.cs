
using ST_Instruct;
using ST_StateManager.Object;
using ST_HasH.Generator;

namespace ST_UI
{
    public partial class ST_Renderer
    {
        public void _Init(ST_Instruction P_ST_Instruction)
        {
            ST_StateObject L_ST_StateObject = G_ST_StateWorker._Get(P_ST_Instruction.StateId);

            P_ST_Instruction.HTMLs.Add(new ST_Instruction_HTML
            {
                TargetId = "Div_Body",
                HTML = G_SF_HTMLGenerator._BuildHtml(G_Components._Home(L_ST_StateObject)).ToString()
            });

            P_ST_Instruction.HTMLs.Add(new ST_Instruction_HTML
            {
                TargetId = G_Components.G_BusyHolderId,
                HTML = G_SF_HTMLGenerator._BuildHtml(G_Components._Busy()).ToString()
            });
        }
    }
}
