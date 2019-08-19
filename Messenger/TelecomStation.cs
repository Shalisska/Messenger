namespace Messenger
{
    class TelecomStation
    {
        public static void Connect(IMessenger from, IMessenger to)
        {
            from.Connect(ConnectUncleMajor(to));
        }

        public static IMessenger ConnectUncleMajor(IMessenger messenger)
        {
            return new UncleMajorMessenger(messenger);
        }
    }
}