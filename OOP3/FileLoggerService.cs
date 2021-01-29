using System;

class FileLoggerService : IloggerService
{
    public void log()
    {
        Console.WriteLine("Dosyaya Loglandı");
    }
}
