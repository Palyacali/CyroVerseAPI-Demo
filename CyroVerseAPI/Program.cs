using CyroVerseAPI;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Bu satır, direkt ana adrese (http://localhost:5002) girdiğinde çalışır
app.MapGet("/", () => "CyroTech: CyroVerse API Sistemleri Aktif!");

// Bu satır, http://localhost:5002/characters adresinde çalışır
app.MapGet("/characters", () => new[] { 
    new { Name = "Avcı", Role = "Sniper", Galaxy = "Nivalis" },
    new { Name = "Bard", Role = "AI General", Galaxy = "Cyrobit" }
});

app.Run();