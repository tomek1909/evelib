using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Diagnostics
{
    [Flags]
    public enum SourceLevels
    {
        Off = 0,
        Critical = 0x01,
        Error = 0x03,
        Warning = 0x07,
        Information = 0x0F,
        Verbose = 0x1F,

        All = unchecked((int)0xFFFFFFFF),
    }

    public enum TraceEventType
    {
        Critical = 0x01,
        Error = 0x02,
        Warning = 0x04,
        Information = 0x08,
        Verbose = 0x10,
        Start,
        Stop,
    }

    public class TraceSource
    {
        public TraceSource(string name, SourceLevels flag = SourceLevels.All)
        {

        }

        public void TraceEvent(TraceEventType eventType, int id, params object[] param)
        {

        }
    }
}
