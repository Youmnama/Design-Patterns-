using Singleton_Thread_Unsafe.Start;

namespace BasicProblem
{
    internal class Program
    {
       
        
            static MemoryLogger logger;
            static void Main(string[] args)
            {

                AssignVoucher("Youmna@gmail.com", "19ll1999");
                UseVoucher("19ll1999");
                logger.ShowLog();












            }

            //method to save email and Voucher if it assigned and save error if it happend
            static void AssignVoucher(string email, string voucher)
            {

                logger = MemoryLogger.GetLog;
                logger.LogInfo($"Voucher '{voucher}' assigned");
                logger.LogError($"Unable to send email '{email}' ");



            }

            //calling when user use Voucher at anytime
            static void UseVoucher(string voucher)
            {

                logger = MemoryLogger.GetLog;
                logger.LogWarning($"Valdate the voucher");
                logger.LogInfo($" {voucher} Voucher is used");



            }
        }
    }

