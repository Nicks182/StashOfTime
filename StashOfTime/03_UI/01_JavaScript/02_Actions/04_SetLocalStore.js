

function _HasH_Action_SetLocalStore(P_Action)
{
    try
    {
        localStorage.setItem(P_Action.TargetId, P_Action.Value);
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}

