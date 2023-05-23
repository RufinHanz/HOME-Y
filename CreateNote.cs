class CreateNote : ChecklistNote
{
    public CreateNote(string _title) : base(_title) { }

    public override void Display()
    {
        Console.WriteLine($"Creating checklist note: {title}");
    }
}