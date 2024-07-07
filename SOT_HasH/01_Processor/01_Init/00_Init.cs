
using SOT_HasH.Generator;
using SOT_Instruction;

namespace SOT_HasH
{
    public partial class ST_Processor
    {
        public void _Init(ST_Instruction P_ST_Instruction)
        {
            P_ST_Instruction.HTMLs.Add(new ST_Instruction_HTML
            {
                TargetId = "Div_Body",
                HTML = new ST_HTMLGenny()._BuildHtml(G_Components._Home()).ToString()
            });
            
        }
    }
}
