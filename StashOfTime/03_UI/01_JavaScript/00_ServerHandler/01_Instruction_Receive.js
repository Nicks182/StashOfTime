


function _Instruction_Receive(P_ST_Instruction)
{
    try
    {
        console.log(P_ST_Instruction);

        _HasH_SetHTML(P_ST_Instruction.HTMLs);

        _HasH_ProcessActions(P_ST_Instruction.Actions);

        switch (P_ST_Instruction.InstructionType)
        {
            case "Greetings":

                break;

            case "_DoNothing":

                break;
        }

        _Busy_Hide();
    }
    catch (ex)
    {
        _Busy_Hide();
    }
}