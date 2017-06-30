using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerverApp
{
    class Server
    {
        public delegate void ServerEvent(object sender, ServerEventArgs e);
        public ServerEvent ServerChange;

        public Server() { }

        public void Connect(Client client)
        {
            //Kliens átadott példányát regisztrálja be
            this.ServerChange += client.ServerMessageHandler;
            OnServerChange(string.Format("Felhasználó <{0}> csatlakozott!", client.Name));
        }

        public void Disconnect(Client client)
        {
            OnServerChange(string.Format("Felhasználó <{0}> kilépett!", client.Name));
            this.ServerChange -= client.ServerMessageHandler;
        }
        protected void OnServerChange(string message)
        {
            if (ServerChange != null)
            {
                ServerChange(this, new ServerEventArgs(message));
            }
        }
    }
}
