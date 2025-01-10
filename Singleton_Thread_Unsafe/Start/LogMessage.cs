using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Thread_Unsafe.Start
{
    public class LogMessage
    {



        public string Message { get; set; }

        public LogTypes LogType { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            var Times = CreatedAt.ToString("G");
            return $"{Times} :{Message}";
        }
    }
}
