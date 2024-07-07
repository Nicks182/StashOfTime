

function _HasH_Action_GetValue(P_Action)
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
                    P_Action.Value = _HasH_Action_GetValue_Textbox_Textarea(L_Component);
                    break;

                case 1: // Textarea
                    P_Action.Value = _HasH_Action_GetValue_Textbox_Textarea(L_Component);
                    break;

                case 2: // Password
                    P_Action.Value = _HasH_Action_GetValue_Textbox_Textarea(L_Component);
                    break;

                case 3: // Checkbox
                    P_Action.Value = _HasH_Action_GetValue_Checkbox(L_Component);
                    break;
            }
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}


function _HasH_Action_GetValue_Textbox_Textarea(P_Component)
{
    return P_Component.value;
}


function _HasH_Action_GetValue_Checkbox(P_Component)
{
    return P_Component.getAttribute("Value");
}