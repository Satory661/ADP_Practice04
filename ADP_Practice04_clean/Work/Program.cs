namespace ADP_Practice04;

internal class Program
{
    public static void Main(string[] args)
    {
        DocumentCreator[] creators = new DocumentCreator[]
        {
            new ReportCreator(), new ResumeCreator(), new LetterCreator()
        };

        foreach (DocumentCreator creator in creators)
        {
            Document doc = creator.CreateDocument();
            doc.Open();
        }

        DocumentCreator? documentCreator = DocumentChoise.CreateDocumentCreator();
        Document document = null;

        if (documentCreator == null)
        {
            Console.WriteLine("Document not created");
            return;
        }
        
        document = documentCreator?.CreateDocument();
        document.Open();
        

    }
}