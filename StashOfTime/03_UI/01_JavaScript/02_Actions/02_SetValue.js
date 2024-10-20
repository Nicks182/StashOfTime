

function _HasH_Action_Set(P_Action)
{
    _HasH_Action_SetValue(P_Action.TargetId, P_Action.Value);
}

function _HasH_Action_SetValue(P_Id, P_Value)
{
    try
    {
        var L_Element = document.querySelector("#" + P_Id);

        // If value is inner element
        if (L_Element.querySelector("#Value")) 
        {
            _HasH_Action_SetValue(P_Id + " #Value", P_Value);
            return;
        }

        // if element has Value property (like texbox)
        if (_HasProp(L_Element, "value") == true) 
        {
            L_Element.value = P_Value;
            return;
        }

        // if element has Value attribute
        if (_HasAttr(L_Element, "value") == true)
        {
            L_Element.setAttribute("value", P_Value);
            return;
        }

        // if element has Value attribute (like image)
        if (_HasAttr(L_Element, "src") == true)
        {
            L_Element.setAttribute("src", P_Value);
            return;
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}