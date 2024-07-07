
using Microsoft.AspNetCore.SignalR;

using SOT_DB;
using SOT_Instruction;

namespace SOT_WebServer
{
    public class ServerHub(ST_DB P_ST_DB) : Hub
    {
        const string G_IsInit = "Init";

        private readonly ST_DB G_ST_DB = P_ST_DB;

        public override Task OnConnectedAsync()
        {
            Clients.Client(Context.ConnectionId).SendAsync("ReceiveConnID", Context.ConnectionId);
            HubUserHandler.ConnectedIds.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? P_Ex)
        {
            HubUserHandler.ConnectedIds.Remove(Context.ConnectionId);
            
            return base.OnDisconnectedAsync(P_Ex);
        }

        public async Task ServerMessageHandler(string Message)
        {
            ST_Instruction L_ST_Instruction;

            if (string.IsNullOrEmpty(Message) == false && Message == G_IsInit)
            {
                L_ST_Instruction = ST_Instruction.Create(ST_Instruction_Type.Init);
            }
            else
            {
                L_ST_Instruction = Newtonsoft.Json.JsonConvert.DeserializeObject<ST_Instruction>(Message)!;
            }
            

            new SOT_Core.ST_Processor(G_ST_DB)._ProcessInstruction(L_ST_Instruction);

            new SOT_HasH.ST_Processor()._ProcessInstruction(L_ST_Instruction);

            // Here we just respond to the window that made the call to the server.
            await Clients.Caller.SendAsync("ClientMessageHandler", L_ST_Instruction);
        }


    }

    public static class HubUserHandler
    {
        public static HashSet<string> ConnectedIds = [];
    }
}
