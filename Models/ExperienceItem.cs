namespace OsandaPortfolio.Models;

public class ExperienceItem
{
    public string Company { get; set; } = "";
    public string Role { get; set; } = "";
    public string DateRange { get; set; } = "";
    public string Location { get; set; } = "";
    public List<string> Highlights { get; set; } = new();
}
