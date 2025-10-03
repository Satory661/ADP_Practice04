namespace ADP_Practice04;
public interface ITodItem
{
    void Print();
}

public class WorkToDoItem : ITodItem
{
    private string _description;
    private DateTime _date;

    public WorkToDoItem(string description, DateTime date)
    {
        this._description = description;
        this._date = date;
    }
    
    public void Print()
    {
        Console.WriteLine(this._description);
        Console.WriteLine(this._date);
    }
}

public class PersonalToDoItem : ITodItem
{
    private string _description;
    private DateTime _date;

    public PersonalToDoItem(string description, DateTime date)
    {
        this._description = description;
        this._date = date;
    }
    
    public void Print()
    {
        Console.WriteLine(this._description);
        Console.WriteLine(this._date);
    }
}

public abstract class ToDoCreator
{
    public abstract ITodItem CreateToDoItem(string description, DateTime date);
}

public class WorkToDoCreator : ToDoCreator
{
    public override ITodItem CreateToDoItem(string description, DateTime date)
    {
        return new WorkToDoItem(description, date);
    }
}

public class PersonalToDoCreator : ToDoCreator
{
    public override ITodItem CreateToDoItem(string description, DateTime date)
    {
        return new PersonalToDoItem(description, date);
    }
}