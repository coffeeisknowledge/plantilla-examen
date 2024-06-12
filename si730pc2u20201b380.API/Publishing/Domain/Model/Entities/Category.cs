using si730pc2u20201b380.API.Publishing.Domain.Model.Aggregates;

namespace si730pc2u20201b380.API.Publishing.Domain.Model.Entities;

public class Category
{
    public Category()
    {
        Name = string.Empty;
    }


    public Category(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<Tutorial> Tutorials { get; }
}