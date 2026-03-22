public class BookViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishedYear { get; set; }
    public string Genre { get; set; }

    public bool IsAvailable { get; set; }

    // Advanced Practice
    public string? BorrowerName { get; set; }
}