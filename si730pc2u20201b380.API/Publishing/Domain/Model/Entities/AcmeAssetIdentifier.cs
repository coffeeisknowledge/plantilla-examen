namespace si730pc2u20201b380.API.Publishing.Domain.Model.Entities;

public record AcmeAssetIdentifier(Guid Identifier)
{
    public AcmeAssetIdentifier() : this(Guid.NewGuid())
    {
    }
}