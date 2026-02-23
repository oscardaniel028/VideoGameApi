using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VideoGameApi.Business.Interfaces;
using VideoGameApi.Business.Models;
using VideoGameApi.Business.Servicios;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        private readonly IVideoGameService _videoGameService;

        public VideoGameController(IVideoGameService videoGameService)
        {
            _videoGameService = videoGameService;
        }

        [HttpGet("{id}")]
        public ActionResult GetVideoGame(int id)
        {
            var videoGame = _videoGameService.GetVideoGame(id);
            if (videoGame == null)
            {
                return NotFound();

            }
            return Ok(videoGame);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAllVideoGames()
        {
            var videoGames = _videoGameService.GetAllVideoGames();
            return Ok(videoGames);
        }

        [HttpGet("buscar")]
        public IActionResult GetVideoGameByName(string nombre)
        {
            var videoGame = _videoGameService.GetVideoGameByName(nombre);   
            if (videoGame == null)
            {
                return NotFound();
            }
            return Ok(videoGame);
        }

        [HttpPost]
        public IActionResult AddVideoGame([FromBody]VideoGameModel videoGame)
        {
            _videoGameService.AddVideoGame(videoGame);
            return Ok("El VideoJuego Fue Agregado Correctamente");
        }

        [HttpPut]
        public IActionResult UpdateVideoGame(int id, [FromBody]VideoGameModel videoGame)
        {
            var existingVideoGame = _videoGameService.GetVideoGame(id);
            if (existingVideoGame == null)
            {
                return NotFound();
            }
            _videoGameService.UpdateVideoGame(id, videoGame);
            return Ok("El Videojuego fue añadido satisfactoriamente");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideoGame(int id)
        {
            var existingVideoGame = _videoGameService.GetVideoGame(id);
            if (existingVideoGame == null)
            {
                return NotFound();
            }
            _videoGameService.DeleteVideoGame(id);
            return Ok();
        }
    }
}
