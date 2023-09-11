using System;

namespace Lab_02_3
{
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine($"Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine($"Редактирование документа доступно в версии Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine($"Сохранение документа доступно в версии Pro");
        }
    }

    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine($"Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine($"Документ сохранен в старом формате");
        }
    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine($"Документ сохранен в новом формате");
        }
    }
}