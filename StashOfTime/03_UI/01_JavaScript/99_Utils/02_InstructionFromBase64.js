
function _HasH_InstructionFromBase64(P_ST_Instruction64)
{
    try
    {
        return JSON.parse(atob(P_ST_Instruction64));

    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}