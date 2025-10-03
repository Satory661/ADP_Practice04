namespace ADP_Practice04;
public class DocumentChoise
{
    public static DocumentCreator? CreateDocumentCreator()
    {
        Console.WriteLine("Document type (1- Letter, 2- Report, 3- Invoice, 4- Resume):");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                return new LetterCreator();
                break;
            case 2:
                
                return new ReportCreator();
                break;
            case 3:
                return new InvoiceCreator();
                break;
            case 4:
                return new ResumeCreator();
                break;
            default:
                return null;
                break;
            
        }
    }
}