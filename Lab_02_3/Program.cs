using System;

namespace Lab_02_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string keyPro = "1234Pro";
            string keyExp = "1234Exp";

            Console.WriteLine($"Please enter the key");
            string userKey = Console.ReadLine();
            if (userKey == keyPro)
            {
                ProDocumentWorker document1 = new ProDocumentWorker();
                document1.OpenDocument();
                document1.EditDocument();
                document1.SaveDocument();
            }
            else if (userKey == keyExp)
            {
                ExpertDocumentWorker document1 = new ExpertDocumentWorker();
                document1.OpenDocument();
                document1.EditDocument();
                document1.SaveDocument();
            }
            else if ((userKey != keyExp) && userKey != keyPro)
            {
                DocumentWorker document1 = new DocumentWorker();
                document1.OpenDocument();
                document1.EditDocument();
                document1.SaveDocument();
            }
        }
    }
}