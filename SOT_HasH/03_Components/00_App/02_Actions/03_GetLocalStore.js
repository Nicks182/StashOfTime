

function _HasH_Action_GetLocalStore(P_Action)
{
    try
    {
        P_Action.Value = localStorage.getItem(P_Action.TargetId);
        //if (P_Action.Value == null)
        //{
        //    P_Action.Value = "_NA_";
        //}
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}
