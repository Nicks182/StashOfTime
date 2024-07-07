

function _HasH_Action_SetFocus(P_Action)
{
    try
    {
        var L_Component = document.getElementById(P_Action.TargetId);
        if (L_Component != null)
        {
            var L_CompType = parseInt(L_Component.getAttribute("CompType"));

            switch (L_CompType)
            {
                case 0: // Textbox
                    _HasH_Action_SetFocus_Generic(L_Component)
                    break;

                case 1: // Textarea
                    _HasH_Action_SetFocus_Generic(L_Component)
                    break;

                case 2: // Checkbox
                    _HasH_Action_SetFocus_Generic(L_Component)
                    break;

                case 3: // Button
                    _HasH_Action_SetFocus_Generic(L_Component)
                    break;
            }
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}


function _HasH_Action_SetFocus_Generic(P_Component)
{
    try
    {
        P_Component.focus();
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}

