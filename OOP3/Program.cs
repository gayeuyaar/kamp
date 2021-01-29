using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            IloggerService DatabaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLogerService = new FileLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());


            List<KrediManager>krediler = new List<KrediManager>();

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            
        }
    }
}
