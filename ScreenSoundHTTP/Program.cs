using System.Text.Json;
using ScreenSoundHTTP.Filters;
using ScreenSoundHTTP.Models;

using (HttpClient client = new()) {
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;

        //LinqFilter.FilterGenres(musics);
        //LinqOrder.OrderArtists(musics);
        //LinqFilter.FilterArtistsByGenres(musics, "hip hop");
        //LinqFilter.FilterMusicsByArtist(musics, "Sean Paul");

        var myFavoriteMusics = new FavoriteMusics("Felipe");
        myFavoriteMusics.AddFavoriteMusics(musics[321]);
        myFavoriteMusics.AddFavoriteMusics(musics[31]);
        myFavoriteMusics.AddFavoriteMusics(musics[214]);
        myFavoriteMusics.AddFavoriteMusics(musics[1321]);
        myFavoriteMusics.AddFavoriteMusics(musics[1521]);

        myFavoriteMusics.ShowFavoriteMusics();
        myFavoriteMusics.GenerateJsonFile();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}