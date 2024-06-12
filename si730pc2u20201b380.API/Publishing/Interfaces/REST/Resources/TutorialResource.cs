namespace si730pc2u20201b380.API.Publishing.Interfaces.REST.Resources;

public record TutorialResource(int Id, string Title, string Summary, CategoryResource Category, string Status);