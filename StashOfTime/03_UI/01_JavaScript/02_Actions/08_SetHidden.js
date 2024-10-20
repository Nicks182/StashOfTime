

function _HasH_Action_SetHidden(P_Action)
{
    try
    {
        var L_Component = document.getElementById(P_Action.TargetId);
        if (L_Component != null)
        {
            L_Component.setAttribute("ishidden", P_Action.Value);
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}