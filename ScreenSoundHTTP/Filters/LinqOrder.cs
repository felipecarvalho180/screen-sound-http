
using ScreenSoundHTTP.Models;

namespace ScreenSoundHTTP.Filters;

internal class LinqOrder
{
	public static void OrderArtists(List<Music> musics)
	{
		var orderedArtists = musics.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();

        foreach (var artist in orderedArtists)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}

