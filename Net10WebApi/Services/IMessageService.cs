using System.Collections.Generic;

namespace Net10WebApi.Services
{
    public interface IMessageService
    {
        IEnumerable<string> GetMessages();
        void AddMessage(string message);
    }
}
