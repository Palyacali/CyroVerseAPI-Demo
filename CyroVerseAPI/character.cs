namespace CyroVerseAPI;

public class Characters
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty; // Örn: Keskin Nişancı
    public string Galaxy { get; set; } = string.Empty; // Örn: Nivalis
    public int PowerLevel { get; set; }
}