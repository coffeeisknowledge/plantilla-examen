namespace si730pc2u20201b380.API.Sales.Domain.Model.ValueObjects;

public record ResumeUrl(string resumeUrl)
{
    public ResumeUrl() : this(string.Empty) {}

    public string GetResumeUrl => resumeUrl;
}