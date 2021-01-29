using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,IloggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme.

            krediManager.Hesapla();
            loggerService.Log();
        }
            public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)

        {
            List<IKrediManager> krediler1 = krediler;

       
        }

        internal void BasvuruYap(İhtiyacKrediManager ihtiyacKrediManager, DatabaseLoggerService databaseLoggerService)
        {
            throw new NotImplementedException();
        }

        internal void KrediOnBilgilendirmesiYap(List<KrediManager> krediler)
        {
            throw new NotImplementedException();
        }
    }
}
