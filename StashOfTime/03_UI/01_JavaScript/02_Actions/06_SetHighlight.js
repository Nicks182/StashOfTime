

function _HasH_Action_SetHighlight(P_Action)
{
    try
    {
        var L_Component = document.getElementById(P_Action.TargetId);
        if (L_Component != null)
        {
            P_Component.select();
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}


