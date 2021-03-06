using NitroxModel.DataStructures.GameLogic;
using NitroxModel.Logger;
using NitroxModel.Serialization;
using NitroxModel.Server;
using NitroxServer.ConsoleCommands.Abstract;
using NitroxServer.ConsoleCommands.Abstract.Type;
using NitroxServer.Serialization;

namespace NitroxServer.ConsoleCommands
{
    internal class ChangeServerPasswordCommand : Command
    {
        public ChangeServerPasswordCommand() : base("changeserverpassword", Perms.ADMIN, "Changes server password. Clear it without argument")
        {
            AddParameter(new TypeString("password", false));
        }

        protected override void Execute(CallArgs args)
        {
            string password = args.Get(0) ?? string.Empty;

            ServerConfig serverConfig = NitroxConfig.Deserialize<ServerConfig>();
            serverConfig.ServerPassword = password;
            NitroxConfig.Serialize(serverConfig);

            Log.InfoSensitive("Server password changed to {password} by {playername}", password, args.SenderName);
            SendMessageToPlayer(args.Sender, "Server password changed. In order to take effect pls restart the server.");
        }
    }
}
