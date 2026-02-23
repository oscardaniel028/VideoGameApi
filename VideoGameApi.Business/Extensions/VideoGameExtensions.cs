using VideoGameApi.Data.Entities;
using VideoGameApi.Business.Models;

namespace VideoGameApi.Business.Extensions
{
    public static class VideoGameExtensions
    {
        public static VideoGameModel Map (this VideoGameEntity videoGameEntity)
        {
            return new VideoGameModel
            {
                Nombre = videoGameEntity.Nombre,
                Genero = videoGameEntity.Genero,
                Precio = videoGameEntity.Precio,
                FechaLanzamiento = videoGameEntity.FechaLanzamiento,
            };
        }

        public static VideoGameEntity Map (this VideoGameModel videoGameModel)
        {
            return new VideoGameEntity
            {
                Nombre = videoGameModel.Nombre,
                Genero = videoGameModel.Genero,
                Precio = videoGameModel.Precio,
                FechaLanzamiento = videoGameModel.FechaLanzamiento,
            };
        }

    }
}
