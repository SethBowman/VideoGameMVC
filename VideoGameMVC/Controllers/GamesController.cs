using Microsoft.AspNetCore.Mvc;
using System.Data;

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
    }
}
