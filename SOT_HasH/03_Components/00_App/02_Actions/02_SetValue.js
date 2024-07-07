

function _HasH_Action_SetValue(P_Action)
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
                    _HasH_Action_SetValue_Textbox_Textarea(L_Component, P_Action.Value);
                    break;

                case 1: // Label
                    _HasH_Action_SetValue_Label(L_Component, P_Action.Value);
                    break;

                case 2: // Password
                    _HasH_Action_SetValue_Textbox_Textarea(L_Component, P_Action.Value);
                    break;

                case 3: // Checkbox
                    _HasH_Action_SetValue_Checkbox(L_Component, P_Action.Value);
                    break;

                case 4: // Button
                    _HasH_Action_SetValue_Button(L_Component, P_Action.Value);
                    break;

                case 5: // Select/Dropdown
                    _HasH_Action_SetValue_Dropdown(L_Component, P_Action.Value);
                    break;

                case 6: // Progressbar
                    _HasH_Action_SetValue_Progressbar(L_Component, P_Action.Value);
                    break;

                case 8: // PlainText/Paragraph
                    _HasH_Action_SetValue_Paragraph(L_Component, P_Action.Value);
                    break;
            }
        }
    }
    catch (P_Ex)
    {
        _HasH_LogError(P_Ex);
    }
}


function _HasH_Action_SetValue_Textbox_Textarea(P_Component, P_Value)
{
    P_Component.value = P_Value;
}

function _HasH_Action_SetValue_Label(P_Component, P_Value)
{
    console.log(P_Component);
    console.log(P_Value);
    P_Component.textContent = P_Value;
}


function _HasH_Action_SetValue_Checkbox(P_Component, P_Value)
{
    P_Component.setAttribute("Value", P_Value);
}

function _HasH_Action_SetValue_Button(P_Component, P_Value)
{
    P_Component.setAttribute("Value", P_Value);
    var L_Caption = P_Component.getElementsByTagName('label')[0];
    L_Caption.textContent = P_Value;
}

function _HasH_Action_SetValue_Dropdown(P_Component, P_Value)
{
    P_Component.setAttribute("Value", P_Value);
    var L_Caption = P_Component.getElementsByTagName('label')[0];
    L_Caption.textContent = P_Value;
}

function _HasH_Action_SetValue_FolderBrowser(P_Component, P_Value)
{
    P_Component.setAttribute("Value", P_Value);
    var L_Caption = P_Component.getElementsByTagName('label')[0];
    L_Caption.textContent = P_Value;
}

function _HasH_Action_SetValue_Progressbar(P_Component, P_Value)
{
    P_Component.setAttribute("Value", P_Value);
    P_Component.setAttribute("style", "--ProgressbarWidth: " + P_Value + ";");

    var L_Text = P_Component.getElementsByTagName('label')[0];
    L_Text.textContent = P_Value;
}

function _HasH_Action_SetValue_Paragraph(P_Component, P_Value)
{
    P_Component.textContent = P_Value;
}