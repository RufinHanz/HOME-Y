class DeleteNote : ChecklistNote
{
    public DeleteNote(string _title) : base(_title) { }

    public override void Display()
    {
        Console.WriteLine($"Deleting checklist note: {title}");
    }
}