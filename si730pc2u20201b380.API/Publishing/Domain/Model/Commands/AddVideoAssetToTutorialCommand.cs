namespace si730pc2u20201b380.API.Publishing.Domain.Model.Commands;

public record AddVideoAssetToTutorialCommand(string VideoUrl, int TutorialId);