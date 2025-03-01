using PrimsTest.Services.Interfaces;

namespace PrimsTest.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
