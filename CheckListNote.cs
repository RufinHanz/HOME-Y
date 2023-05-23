abstract class ChecklistNote
{
    protected string title;
    protected bool completed;

    public ChecklistNote(string _title)
    {
        title = _title;
        completed = false;
    }

    public abstract void Display();

    public void MarkAsCompleted()
    {
        completed = true;
        Console.WriteLine($"{title} marked as completed.");
    }
}