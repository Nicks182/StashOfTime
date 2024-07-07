


function _Instruction_Send(P_ST_Instruction)
{
    G_HubConnection.invoke("ServerMessageHandler", _ToJSONString(P_ST_Instruction));
}