namespace si730pc2u20201b380.API.Subscriptions.Domain.Model.ValueObjects;

public record PlanDefault(int Default)
{
   public PlanDefault() : this(0)
   {
   }

   public int GetDefault => Default;
}