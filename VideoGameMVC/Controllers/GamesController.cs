using Microsoft.AspNetCore.Mvc;
using System.Data;
using VideoGameMVC.Models;

namespace VideoGameMVC.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameRepo _repo;
        public GamesController(IGameRepo repo)
        {
            _repo = repo;   
        }
        public IActionResult Index()
        {
            var games = _repo.GetAllGames();
            return View(games);
        }

        public IActionResult ViewGame(int id)
        {
            var game = _repo.GetGame(id);
            return View(game);
        }

        public IActionResult UpdateGame(int id)
        {
            Game game = _repo.GetGame(id);

            if(game == null)
            {
                return View("GameNotFound");
            }
            return View(game);
        }

        public IActionResult UpdateGameToDatabase(Game game)
        {
            _repo.UpdateGame(game);

            return RedirectToAction("ViewGame", new { id = game.Id });
        }
    }
}
