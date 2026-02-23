using VideoGameApi.Business.Extensions;
using VideoGameApi.Business.Interfaces;
using VideoGameApi.Business.Models;
using VideoGameApi.Business.Repository_Interfaces;

namespace VideoGameApi.Business.Servicios
{
    public class VideoGameService: IVideoGameService
    {
        private readonly IVideoGameRepository _repository;

        public VideoGameService(IVideoGameRepository repository)
        {
            _repository = repository;
        }

        public VideoGameModel GetVideoGame(int id)
        {
            var entity = _repository.GetById(id);
            return entity?.Map();
        }

        public IEnumerable<VideoGameModel> GetAllVideoGames()
        {
            var entities = _repository.GetAll();
            return entities.Select(e => e.Map());
        }

        public VideoGameModel GetVideoGameByName(string nombre)
        {
            var entity = _repository.GetByName(nombre); 
            return entity?.Map();
        }

        public void AddVideoGame(VideoGameModel videoGameModel)
        {
            var entity = videoGameModel.Map();
            _repository.Add(entity);
            _repository.Save();
        }

        public void UpdateVideoGame (int id, VideoGameModel videoGameModel)
        {
            var entity = _repository.GetById(id);
            if (entity != null)
            {
                entity.Nombre = videoGameModel.Nombre;
                entity.Genero = videoGameModel.Genero;
                entity.Precio = videoGameModel.Precio;
                entity.FechaLanzamiento = videoGameModel.FechaLanzamiento;

                _repository.Update(entity);
                _repository.Save();
            }
        }

        public void DeleteVideoGame(int id)
        {
            var entity = _repository.GetById(id);
            if (entity != null)
            {
                _repository.Delete(entity);
                _repository.Save();
            }
        }
    }
}
