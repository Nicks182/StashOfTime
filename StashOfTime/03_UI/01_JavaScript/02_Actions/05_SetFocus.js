

function _HasH_Action_SetFocus(P_Action)
{
    try
    {
        var L_Component = document.getElementById(P_Action.TargetId);
        if (L_Component != null)
        {
            P_Component.focus();
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}


