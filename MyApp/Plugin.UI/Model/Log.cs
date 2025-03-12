using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.UI.Model
{
    public enum LogType
    {
        Info,
        Warning,
        Error
    }
    class Log
    {
        public LogType Type { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public Log(LogType type, string message)
        {
            Type = type;
            Message = message;
            Time = DateTime.Now;
        }
    }
}
