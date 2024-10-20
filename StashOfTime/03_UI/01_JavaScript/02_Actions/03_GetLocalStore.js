

function _HasH_Action_GetLocalStore(P_Action)
{
    try
    {
        P_Action.Value = localStorage.getItem(P_Action.TargetId);
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}
