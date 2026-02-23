using VideoGameApi.Business.Models;

namespace VideoGameApi.Business.Interfaces
{
    public interface IVideoGameService
    {
        VideoGameModel GetVideoGame(int id);
        IEnumerable<VideoGameModel> GetAllVideoGames();
        VideoGameModel GetVideoGameByName(string nombre);

        void AddVideoGame(VideoGameModel videogame);
        void UpdateVideoGame(int id,VideoGameModel videogame);
        void DeleteVideoGame(int id);
    }
}
