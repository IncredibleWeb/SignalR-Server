using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ChatApplication.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message, string roomName)
        {
            Clients.Group(roomName).GetMessage(name, message);
        }

        public Task JoinRoom(string roomName)
        {
            return Groups.Add(Context.ConnectionId, roomName);
        }

        public Task LeaveRooom(string roomName)
        {
            return Groups.Remove(Context.ConnectionId, roomName);
        }
    }
}