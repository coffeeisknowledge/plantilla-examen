namespace si730pc2u20201b380.API.Subscriptions.Domain.Model.Commands;

public record CreatePlanCommand(string Name, int MaxUsers, int Default);