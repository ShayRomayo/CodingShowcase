namespace CodingShowcase.Shared;

public class SearchableItem
{
    public int Id { get; set; }
    public string Name { get; set; }

    public SearchableItem(int id, string name)
    {
        Id = id;
        Name = name;
    }
}