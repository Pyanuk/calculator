internal class Note
{
    private string? title;
    private string? description;
    private DateTime date;

    public Note(string? title, string? description, DateTime date)
    {
        this.title = title;
        this.description = description;
        this.date = date;
    }
}