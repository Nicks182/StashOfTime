
function _HasProp(P_Object, P_Target) 
{
    if (P_Object && P_Target) 
    {
        for (const key in P_Object) 
        {
            if (key === P_Target) 
            {
                return true;
            }
        }
    }

    return false;
}