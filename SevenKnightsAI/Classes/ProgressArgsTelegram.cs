namespace SevenKnightsAI.Classes
{
    internal class ProgressArgsTelegram
    {

        public ProgressArgsTelegram(ProgressType type, object message)
        {
            Type = type;
            Message = message;
        }

        public object Message
        {
            get;
            private set;
        }

        public ProgressType Type
        {
            get;
            private set;
        }
    }
}