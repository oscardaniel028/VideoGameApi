using VideoGameApi.Data.Entities;

namespace VideoGameApi.Business.Repository_Interfaces
{
    public interface IVideoGameRepository
    {
        VideoGameEntity GetById(int id);
        IEnumerable<VideoGameEntity> GetAll();
        VideoGameEntity GetByName(string nombre);
        void Add(VideoGameEntity entity);
        void Update(VideoGameEntity entity);
        void Delete(VideoGameEntity entity);
        void Save();
    }
}
