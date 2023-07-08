using ScreenSoundHTTP.Models;

namespace ScreenSoundHTTP.Filters;

internal class LinqFilter
{
	public static void FilterGenres(List<Music> musics)
	{
		var allGenres = musics.Select(music => music.Genre).Distinct().ToList();

		foreach (var genre in allGenres)
		{
			Console.WriteLine($"- {genre}");
		}
	}

	public static void FilterArtistsByGenres(List<Music> musics, string genre)
	{
		var artistsByGenre = musics.Where(music => music.Genre!.Contains(genre)).Select(music => music.Artist).Distinct().ToList();

		Console.WriteLine($"Artistas do gênero musical {genre}\n");
		foreach (var artist in artistsByGenre)
		{
			Console.WriteLine($"- {artist}");
		}
	}

	public static void FilterMusicsByArtist(List<Music> musics, string artist)
	{
		var artistMusics = musics.Where(music => music.Artist!.Equals(artist)).ToList();

		Console.WriteLine($"Músicas do artista {artist}");
        foreach (var music in artistMusics)
        {
            Console.WriteLine($"- {music.Name}");
        }
    }
}

