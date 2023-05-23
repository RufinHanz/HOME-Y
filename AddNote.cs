class AddNote : ChecklistNote
{
    public AddNote(string _title) : base(_title) { }

    public override void Display()
    {
        Console.WriteLine($"Adding checklist note: {title}");
    }
}