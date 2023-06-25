using System.Drawing;

namespace LayoutChat.UI.ChatView;

public class MessageChatView
{
    public ClientService _clientService;
    private readonly LayoutMessage _layoutMessage;

    public MessageChatView(Point top, Point left, ClientService clientService)
    {
        _clientService = clientService;

        _layoutMessage = new LayoutMessage(top, left, clientService, clientService.ManagerService);
    }

    public void WriteMessage(string message, Guid clientId)
    {
        if (_clientService.FindModel(clientId) == null)
        {
            Console.WriteLine("Exeption Not Find Client");
            return;
        }

        _clientService.SendMassage(message, clientId);
    }

    public void PrintMessage(Guid activeId)
    {
        _layoutMessage.Write(activeId);
    }
}