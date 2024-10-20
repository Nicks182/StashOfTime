
using Microsoft.AspNetCore.SignalR;

using ST_DB;
using ST_DB.Worker;
using ST_Instruct;
using ST_StateManager.Worker;

namespace ST_WebServer
{
    public class ServerHub(ST_StateWorker P_ST_StateWorker, ST_DbWorker P_ST_DbWorker) : Hub
    {
        const string G_IsInit = "Init";

        private readonly ST_StateWorker G_ST_StateWorker = P_ST_StateWorker;
        private readonly ST_DbWorker G_ST_DbWorker = P_ST_DbWorker;

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
            try
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


                new ST_Core.ST_Processor(G_ST_StateWorker, G_ST_DbWorker)._ProcessInstruction(L_ST_Instruction);

                new ST_UI.ST_Renderer(G_ST_StateWorker)._RenderInstruction(L_ST_Instruction);

                // Here we just respond to the window that made the call to the server.
                await Clients.All.SendAsync("ClientMessageHandler", L_ST_Instruction);
            }
            catch (Exception ex)
            {
                throw ex; // TODO Fix this later...
            }
        }


    }

    public static class HubUserHandler
    {
        public static HashSet<string> ConnectedIds = [];
    }
}
