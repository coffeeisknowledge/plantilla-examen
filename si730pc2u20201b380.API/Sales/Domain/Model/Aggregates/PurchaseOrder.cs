using si730pc2u20201b380.API.Sales.Domain.Model.ValueObjects;
using Country = Microsoft.EntityFrameworkCore.TestModels.Inheritance.Country;

namespace si730pc2u20201b380.API.Sales.Domain.Model.Aggregates;

public class PurchaseOrder
{
    public int Id { get; }
    
    public Country POCountry { get; private set; }
    
    public Customer POCustomer { get; private set; }
    
    public EFabricId POEFrabricId { get; private set; }
    
    public Quantity POQuantity { get; private set; }
    
    public ResumeUrl POResumeUrl { get; private set; }

    public PurchaseOrder()
    {
        POCountry = new Country();
        POCustomer = new Customer();
        POEFrabricId = EFabricId.Algodon;
        POQuantity = new Quantity();
        POResumeUrl = new ResumeUrl();
    }
}