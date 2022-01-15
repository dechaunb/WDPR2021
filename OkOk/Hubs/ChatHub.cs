using Microsoft.AspNetCore.SignalR;

namespace OkOk.Hubs
{
    public class ChatHub : Hub
    {
        private readonly static ConnectionMapping<string> _connections = 
            new ConnectionMapping<string>();


        public async Task SendPrivateMessage(string user, string receiver, string message)
        {

            foreach (var connectionId in _connections.GetConnections(receiver))
            {
                Console.WriteLine("found target user connection");
                await Clients.Client(connectionId).SendAsync("ReceivePrivateMessage", user, message);
            }
            foreach (var connectionId in _connections.GetConnections(user))
            {
                Console.WriteLine("found user connection");
                await Clients.Client(connectionId).SendAsync("ReceivePrivateMessage", user, message);
            }

        }

        public override async Task OnConnectedAsync()
        {
            string name = Context.User.Identity.Name;

            _connections.Add(name, Context.ConnectionId);

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)

        {
            string name = Context.User.Identity.Name;

            _connections.Remove(name, Context.ConnectionId);

            await base.OnDisconnectedAsync(exception);
        }


        public string GetConnectionId()=> Context.ConnectionId;
        
    }

    public class ConnectionMapping<T>
    {
        public readonly Dictionary<T, HashSet<string>> _connections =
            new Dictionary<T, HashSet<string>>();

        public int Count
        {
            get
            {
                return _connections.Count;
            }
        }

        public void Add(T key, string connectionId)
        {
            lock (_connections)
            {
                HashSet<string> connections;
                if (!_connections.TryGetValue(key, out connections))
                {
                    connections = new HashSet<string>();
                    _connections.Add(key, connections);
                }

                lock (connections)
                {
                    connections.Add(connectionId);
                }
            }
        }

        public IEnumerable<string> GetConnections(T key)
        {
            HashSet<string> connections;
            if (_connections.TryGetValue(key, out connections))
            {
                return connections;
            }else{
                var error = _connections.TryGetValue(key, out connections);
            }

            return Enumerable.Empty<string>();
        }

        public void Remove(T key, string connectionId)
        {
            lock (_connections)
            {
                HashSet<string> connections;
                if (!_connections.TryGetValue(key, out connections))
                {
                    return;
                }

                lock (connections)
                {
                    connections.Remove(connectionId);

                    if (connections.Count == 0)
                    {
                        _connections.Remove(key);
                    }
                }
            }
        }
    }

}
