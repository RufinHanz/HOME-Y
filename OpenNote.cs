class OpenNote : ChecklistNote
{
    public OpenNote(string _title) : base(_title) { }

    public override void Display()
    {
        Console.WriteLine($"Opening checklist note: {title}");
    }
}