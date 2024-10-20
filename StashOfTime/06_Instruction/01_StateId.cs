

namespace ST_Instruct
{
    public partial class ST_Instruction
    {
        public Guid StateId { get; set; }
        public ST_Instruction Set_StateId(Guid P_ContextId)
        {
            StateId = P_ContextId;

            return this;
        }

        public ST_Instruction Set_StateId(string P_ContextId)
        {
            if(string.IsNullOrEmpty(P_ContextId) == false)
            {
                StateId = Guid.Parse(P_ContextId);
            }

            return this;
        }

    }

}
