namespace VideoGameApi.Data.Entities
{
    public class VideoGameEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }
        public string FechaLanzamiento { get; set; }
    }
}
