using System;

namespace SignalRCoreServerHubWPF
{
    public class SignalRTime
    {

        //public SignalRTime()
        //{

        //}

        public double SendTime { get; set; }
        public double HubReceivedTime { get; set; }
        public double ClientReceivedTime { get; set; }
        public double ClientMessageTime { get; set; }
    }
}
