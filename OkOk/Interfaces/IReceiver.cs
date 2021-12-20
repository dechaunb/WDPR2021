using OkOk.Models;

namespace OkOk.Interfaces
{
    interface IReceiver
    {
        ICollection<Message> Messages { get; set; }
    }
}