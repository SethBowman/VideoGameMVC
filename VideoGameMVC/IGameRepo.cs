using VideoGameMVC.Models;

namespace VideoGameMVC
{
	public interface IGameRepo
	{
		public IEnumerable<Game> GetAllGames();
		public Game GetGame(int id);
		public void UpdateGame(Game game);

		public void AddGame(Game gameToAdd);		
		public void RemoveGame(Game gameToRemove);
	}
}
