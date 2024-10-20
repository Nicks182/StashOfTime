


function _Instruction_Send(P_ST_Instruction)
{
    try
    {
        _Busy_Show();
        var L_ST_Instruction = _HasH_InstructionFromBase64(P_ST_Instruction)
        console.log(L_ST_Instruction);
        _HasH_ProcessActions(L_ST_Instruction.Actions);

        G_HubConnection.invoke("ServerMessageHandler", _ToJSONString(L_ST_Instruction));
    }
    catch (ex)
    {
        _Busy_Hide();
        alert("Function: _Instruction_Send \nMsg: " + ex);
    }
}