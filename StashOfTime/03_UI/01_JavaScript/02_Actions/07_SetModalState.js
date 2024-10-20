

function _HasH_Action_SetModalState(P_Action)
{
    try
    {
        if (P_Action.Value == "0")
        {
            _Modal_Hide(P_Action.TargetId);
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}
