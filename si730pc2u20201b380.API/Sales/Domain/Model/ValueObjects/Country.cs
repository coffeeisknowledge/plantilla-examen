namespace si730pc2u20201b380.API.Sales.Domain.Model.ValueObjects;

public record Country(string country)
{
   public Country() : this(string.Empty) {}

   public string GetCountry => country;
}