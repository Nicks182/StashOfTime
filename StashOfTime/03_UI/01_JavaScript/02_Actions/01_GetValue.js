

function _HasH_Action_Get(P_Action)
{
    P_Action.Value = _HasH_Action_GetValue(P_Action.TargetId);
}

function _HasH_Action_GetValue(P_Id)
{
    try
    {
        var L_Element = document.querySelector("#" + P_Id);

        // If value is inner element
        if (L_Element.querySelector("#Value"))
        {
            return _HasH_Action_GetValue(P_Id + " #Value");
        }

        // if element has Value property (like texbox)
        if (_HasProp(L_Element, "value") == true)
        {
            return L_Element.value;
        }

        // if element has Value attribute
        if (_HasAttr(L_Element, "value") == true)
        {
            return L_Element.getAttribute("value");
        }

        // if element has Value attribute (like image)
        if (_HasAttr(L_Element, "src") == true)
        {
            return L_Element.getAttribute("src");
        }

        return null;
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}

