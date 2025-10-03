namespace ADP_Practice04;

public class ReportCreator: DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Report();
    }
}