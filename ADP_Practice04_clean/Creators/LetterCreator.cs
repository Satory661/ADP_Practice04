namespace ADP_Practice04;

public class LetterCreator: DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Letter();
    }
}