
function _HasAttr(P_Object, P_Target) 
{
    if (P_Object && P_Target) 
    {
        return P_Object.hasAttribute(P_Target);
    }
    return false;
}