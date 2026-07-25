namespace OsandaPortfolio.Models;

public class ProjectItem
{
    public string Tag { get; set; } = "";
    public string Title { get; set; } = "";
    public string DateRange { get; set; } = "";
    public string StackLine { get; set; } = "";
    public List<string> Highlights { get; set; } = new();
    public string? ImageUrl { get; set; }
    public string? ImageAlt { get; set; }
    public string? LinkUrl { get; set; }
}
