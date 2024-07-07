


var G_ConnectionUrl = "/ServerHub";

var G_HubConnection = new signalR.HubConnectionBuilder().withUrl(G_ConnectionUrl).build();

// Setup handler for message from server...    
G_HubConnection.on("ClientMessageHandler", _Instruction_Receive);


document.addEventListener("DOMContentLoaded", () =>
{
    G_HubConnection.start().then(function () 
    {
        console.log("Hub Status: " + G_HubConnection.state);
        _App_Init();
    });
});

function _App_Init()
{
    G_HubConnection.invoke("ServerMessageHandler", "Init");
}