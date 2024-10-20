

namespace ST_Instruct
{
    public partial class ST_Instruction
    {
        
        public ST_Instruction(ST_Instruction_Type P_Type)
        {
            Set_Type(P_Type);
        }

        public static ST_Instruction Create(ST_Instruction_Type P_Type)
        {
            return new ST_Instruction(P_Type);
        }

        
        
    }


}
