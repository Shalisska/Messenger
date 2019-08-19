using System.Collections.Generic;

namespace Messenger
{
    class UncleMajorMessenger : IMessenger
    {
        private IMessenger _messenger;
        private List<string> _stopWords = new List<string>
        {
            "ромашка",
            "кактус"
        };

        public UncleMajorMessenger(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public string Name
        {
            get => _messenger.Name;
            set => _messenger.Name = value;
        }
        public void Connect(IMessenger to)
        {
            _messenger.Connect(to);
        }

        public void OnMessage(IMessenger sender, string message)
        {
            if (CheckMessage(message))
                message = "За вами уже выехали";

            _messenger.OnMessage(sender, message);
        }

        public void Send(string message)
        {
            _messenger.Send(message);
        }

        private bool CheckMessage(string message)
        {
            foreach(var word in _stopWords)
            {
                if (message.Contains(word))
                    return true;
            }

            return false;
        }
    }
}
