

namespace SOT_Instruction
{
    public partial class ST_Instruction
    {
        public Guid ObjectId { get; set; }
        
        public ST_Instruction Set_ObjectId(Guid P_ObjectId)
        {
            ObjectId = P_ObjectId;

            return this;
        }
        
    }

}
