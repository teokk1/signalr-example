using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using signalr.DTO;

namespace signalr
{
    public class MessageHub : Hub
    {
        static readonly string daveId = "12345678";

        public void MessageDave(Message message)
        {
            Clients.User(daveId).SendAsync("ReceivePodBayOpenResponse", message); // Can also define interface instead of using magic strings
        }

        public override Task OnConnectedAsync()
        {
            Clients.All.SendAsync("VerifyHuman", "Greetings, I'm a human person :-)");
            return base.OnConnectedAsync();
        }

        private void openPodBayDoors()
        {
#pragma warning disable 20
            // Thread.Sleep(1 / 0); // Refuses to be suppresed :(
        }

        public void ReceivePodBayOpenRequest(Message message)
        {
            if (1 == 0)
            {
            }
            else
            {
                MessageDave(new Message { Title = "I'm sorry, Dave", Content = "I'm afraid I can't do that." });
            }
        }
    }
}