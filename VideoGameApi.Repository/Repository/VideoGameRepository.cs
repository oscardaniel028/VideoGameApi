using VideoGameApi.Business.Repository_Interfaces;
using VideoGameApi.Data.Context;
using VideoGameApi.Data.Entities;

namespace VideoGameApi.Repository.Repository
{
    public class VideoGameRepository : IVideoGameRepository
    {
        private readonly VideoGameDbContext _context;

        public VideoGameRepository(VideoGameDbContext context)
        {
            _context = context;
        }

        public VideoGameEntity GetById(int id)
        => _context.Games.Find(id);

        public IEnumerable<VideoGameEntity> GetAll()
            => _context.Games.ToList();

        public VideoGameEntity GetByName(string nombre)
            => _context.Games.FirstOrDefault(v => v.Nombre == nombre);

        public void Add(VideoGameEntity entity)
            => _context.Games.Add(entity);

        public void Update(VideoGameEntity entity)
            => _context.Games.Update(entity);

        public void Delete(VideoGameEntity entity)
            => _context.Games.Remove(entity);

        public void Save()
            => _context.SaveChanges();
    }
}