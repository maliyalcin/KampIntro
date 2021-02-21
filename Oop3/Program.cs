using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>{ dataBaseLoggerService, fileLoggerService , smsLoggerService};
            List<ILoggerService> loggers2 = new List<ILoggerService>{dataBaseLoggerService, fileLoggerService};
            List<ILoggerService> loggers3 = new List<ILoggerService>{ smsLoggerService};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, loggers);
            Console.WriteLine("-------------------------------------");
            basvuruManager.BasvuruYap(esnafKrediManager, loggers2);
            Console.WriteLine("-------------------------------------");
            basvuruManager.BasvuruYap(tasitKrediManager, loggers3);
            Console.WriteLine("-------------------------------------");

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
