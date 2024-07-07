

namespace SOT_Instruction
{
    public partial class ST_Instruction
    {
        public Dictionary<string, string> Data { get; set; } = [];
        

        public ST_Instruction Add_Data(string P_Key, string P_Value)
        {
            Data.Add(P_Key, P_Value);

            return this;
        }
    }



}
