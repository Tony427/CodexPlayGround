using System.Collections.Generic;

namespace Net10WebApi.Services
{
    public class MessageService : IMessageService
    {
        private readonly List<string> _messages = new List<string>();
        public IEnumerable<string> GetMessages() => _messages;
        public void AddMessage(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                _messages.Add(message);
            }
        }
    }
}
