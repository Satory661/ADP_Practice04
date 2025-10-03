namespace ADP_Practice04;

public class ResumeCreator: DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Resume();
    }
}