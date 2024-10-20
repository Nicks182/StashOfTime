

namespace ST_Instruct
{
    public partial class ST_Instruction
    {
        public List<ST_Instruction_HTML> HTMLs { get; set; } = [];
        public ST_Instruction Add_HTML(ST_Instruction_HTML P_HTML)
        {
            HTMLs.Add(P_HTML);

            return this;
        }

        public ST_Instruction Add_HTML(string P_TargtId, string P_HTML, bool P_IsAppend = false)
        {
            HTMLs.Add(new ST_Instruction_HTML
            {
                HTML = P_HTML,
                IsAppend = P_IsAppend,
                TargetId = P_TargtId
            });

            return this;
        }
    }

    public class ST_Instruction_HTML
    {
        public string TargetId { get; set; } = string.Empty;
        public string HTML { get; set; } = string.Empty;
        public bool IsAppend { get; set; } = false;
    }


}
