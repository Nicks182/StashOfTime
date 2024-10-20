

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using ST_Instruct;

namespace ST_UI.Component
{
    public partial class Components
    {
        public string _Changed_Event_Handler(ST_Instruction P_ST_Instruction)
        {
            return
            "_Instruction_Send('" +
                _From_Instruction_to_Base64(P_ST_Instruction) +
            "');";
        }

        public string _From_Instruction_to_Base64(ST_Instruction P_ST_Instruction)
        {
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(_ToJSON_String(P_ST_Instruction));
            return Convert.ToBase64String(byt);
        }

        public string _ToJSON_String(object P_Object)
        {
            JsonSerializerSettings L_JsonSerializerSettings = new JsonSerializerSettings();
            L_JsonSerializerSettings.Converters.Add(new StringEnumConverter(null!, true));
            L_JsonSerializerSettings.ContractResolver = new DefaultContractResolver();

            return JsonConvert.SerializeObject(P_Object, L_JsonSerializerSettings);
        }

    }

    
}
