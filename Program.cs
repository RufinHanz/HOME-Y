class Program
{
    static void Main(string[] args)
    {
        List<ChecklistNote> notes = new List<ChecklistNote>();

        notes.Add(new CreateNote("Note 1"));
        notes.Add(new OpenNote("Note 2"));
        notes.Add(new DeleteNote("Note 3"));
        notes.Add(new AddNote("Note 4"));

        Console.WriteLine("Initial checklist notes:");
        foreach (var note in notes)
        {
            note.Display();
        }

        notes[0].MarkAsCompleted();

        Console.WriteLine("\nUpdated checklist notes:");
        foreach (var note in notes)
        {
            note.Display();
        }

        notes.Clear();

        Console.ReadLine();
    }
}