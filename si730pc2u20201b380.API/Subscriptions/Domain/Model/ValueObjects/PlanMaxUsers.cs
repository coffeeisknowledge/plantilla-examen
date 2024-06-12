namespace si730pc2u20201b380.API.Subscriptions.Domain.Model.ValueObjects;

public record PlanMaxUsers(int MaxUsers)
{
   public PlanMaxUsers() : this(0)
   {
      
   }

   public int GetMaxUsers => MaxUsers;
}