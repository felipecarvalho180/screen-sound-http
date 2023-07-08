using System.Text.Json.Serialization;

namespace ScreenSoundHTTP.Models;

internal class Music
{
	[JsonPropertyName("song")]
	public string? Name { get; set; }
	[JsonPropertyName("artist")]
	public string? Artist { get; set; }
	[JsonPropertyName("duration_ms")]
	public int Duration { get; set; }
	[JsonPropertyName("genre")]
	public string? Genre { get; set; }

	public void ShowMusicDetail() {
		Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Música: {Name}");
        Console.WriteLine($"Duração: {Duration}");
        Console.WriteLine($"Gênero musical: {Genre}");
    }
}

