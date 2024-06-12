namespace si730pc2u20201b380.API.Sales.Domain.Model.ValueObjects;

public record Quantity(int quantity)
{
    public Quantity() : this(0){}

    public int GetQuantity => quantity;
}