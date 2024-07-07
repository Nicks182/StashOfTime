function _HasH_ProcessActions(P_Actions)
{
    try
    {
        if (P_Actions)
        {
            for (var i = 0; i < P_Actions.length; i++)
            {
                switch (P_Actions[i].Type)
                {
                    case 1: // "GetValue"
                        _HasH_Action_GetValue(P_Actions[i]);
                        break;

                    case 2: // "SetValue":
                        _HasH_Action_SetValue(P_Actions[i]);
                        break;

                    case 5: // "GetLocalStore":
                        _HasH_Action_GetLocalStore(P_Actions[i]);
                        break;

                    case 6: // "SetLocalStore":
                        _HasH_Action_SetLocalStore(P_Actions[i]);
                        break;

                    case 7: // "SetFocus":
                        _HasH_Action_SetFocus(P_Actions[i]);
                        break;

                    case 8: // "SetHighlight":
                        _HasH_Action_SetHighlight(P_Actions[i]);
                        break;

                    case 9: // "SetHidden":
                        _HasH_Action_SetHidden(P_Actions[i]);
                        break;

                    case 10: // "SetModalState":
                        _HasH_Action_SetModalState(P_Actions[i]);
                        break;
                }
            }

        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}

