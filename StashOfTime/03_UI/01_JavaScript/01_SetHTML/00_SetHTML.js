

function _HasH_SetHTML(P_HTMLs)
{
    try
    {
        var L_Container = null;
        for (var i = 0; i < P_HTMLs.length; i++)
        {
            L_Container = document.getElementById(P_HTMLs[i].TargetId);
            if (L_Container != null)
            {
                L_Container.style.display = "none";
                if (P_HTMLs[i].IsAppend == true)
                {
                    L_Container.innerHTML += P_HTMLs[i].HTML;
                }
                else
                {
                    L_Container.innerHTML = P_HTMLs[i].HTML;
                }

                L_Container.style.display = "";
            }
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}
