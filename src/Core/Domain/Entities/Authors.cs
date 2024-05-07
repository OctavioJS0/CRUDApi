namespace Domain.Entities;

public class Authors
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public DateOnly Birthday { get; set; } = default!;
    public string Nationality { get; set; } = default!;
    public bool Active { get; set; } = default!;
    public List<Books> Books = new();
}