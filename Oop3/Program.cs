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

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager> { new IhtiyacKrediManager(), tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
