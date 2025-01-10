using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Thread_Unsafe.Start
{
    public class MemoryLogger
    {

        private int _infocount;
        private int _warningcount;
        private int _errorcount;
        private static MemoryLogger instance = null; //====>1
        private static readonly object _lock = new object(); //===>1
      


        private MemoryLogger()  //===>2
        {
            
        }


        public static MemoryLogger GetLog
        {

            get
            {
                if(instance == null) /////====== double check

                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            return new MemoryLogger();
                        }
                    }


                    return instance;
                
            }
            
        }
            

        private List<LogMessage> logs=new List<LogMessage>();

        public IReadOnlyCollection<LogMessage> Logs => logs;  //not editable

        private void Log( string message, LogTypes logTypes )    //Method to show message and it's type which saved in db
        {
            logs.Add(new LogMessage { 

                Message =message,
                LogType =logTypes,
                CreatedAt = DateTime.Now
            
            
            
            
            
            });

        }
        public void LogInfo(string message) {


            ++_infocount;
            Log(message, LogTypes.INFO);
       
        
        }
        public void LogWarning(string message)
        {


            ++_warningcount;
            Log(message, LogTypes.WARNING);


        }
        public void LogError(string message)
        {


            ++_errorcount;
            Log(message, LogTypes.ERROR);


        }
       public void ShowLog()
        {
            logs.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"Info {_infocount} ,Warning {_warningcount} ,Error {_errorcount}");
        }











    }
}
