using System;

namespace OwnService
{
    public class TimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
