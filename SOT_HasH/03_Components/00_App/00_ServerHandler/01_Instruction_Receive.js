


function _Instruction_Receive(P_ST_Instruction)
{
    console.log(P_ST_Instruction);

    _HasH_SetHTML(P_ST_Instruction.HTMLs);

    switch (P_ST_Instruction.InstructionType)
    {
        case "Greetings":
            
            break;

        case "_DoNothing":
            
            break;
    }
}