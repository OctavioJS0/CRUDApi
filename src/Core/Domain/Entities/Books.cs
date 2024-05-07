namespace Domain.Entities;

public class Books
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string Synopsis { get; set; } = default!;
    public string Genre { get; set; } = default!;
    public double Price { get; set; }
    public bool Active { get; set; } = default!;
    public List<Authors> Authors = new();

}