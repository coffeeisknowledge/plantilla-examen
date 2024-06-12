namespace si730pc2u20201b380.API.Sales.Domain.Model.ValueObjects;

public record Customer(string customer)
{
   public Customer() : this(string.Empty) {}

   public string GetCustomer => customer;
}