using System.Text.Json;

namespace ScreenSoundHTTP.Models;

internal class FavoriteMusics
{
    public FavoriteMusics(string name)
    {
        Name = name;
        FavoriteMusicList = new();
    }

    public string Name { get; set; }
	public List<Music> FavoriteMusicList { get; set; }


    public void AddFavoriteMusics(Music music)
    {
        FavoriteMusicList.Add(music);
    }

    public void ShowFavoriteMusics()
    {
        Console.WriteLine($"Essas são as músicas favoritas do {Name}");
        foreach (var music in FavoriteMusicList)
        {
            Console.WriteLine($"- {music.Name} de {music.Artist}");
        }
    }

    public void GenerateJsonFile()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            musics = FavoriteMusicList
        });

        string fileName = $"{Name}-favorite-musics.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine($"O arquivo foi gerado com sucesso! {Path.GetFullPath(fileName)}");
    }
}

