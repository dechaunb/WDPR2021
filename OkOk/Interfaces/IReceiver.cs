using OkOk.Models;

namespace OkOk.Interfaces
{
    interface IReceiver
    {
        ICollection<Message> Received { get; set; }
    }
}