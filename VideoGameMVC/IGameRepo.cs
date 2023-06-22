using VideoGameMVC.Models;

namespace VideoGameMVC
{
	public interface IGameRepo
	{
		public IEnumerable<Game> GetAllGames();
	}
}
