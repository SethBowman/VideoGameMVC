using Dapper;
using System.Data;
using VideoGameMVC.Models;

namespace VideoGameMVC
{
	public class GameRepo : IGameRepo
	{
		private readonly IDbConnection _conn;
        public GameRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Game> GetAllGames()
		{
			return _conn.Query<Game>("select * from games");
		}

        public Game GetGame(int id)
        {
            return _conn.QuerySingle<Game>("select * from games where id = @id", new { id = id });
        }

        public void UpdateGame(Game game)
        {
            _conn.Execute("update games set title = @title, genre = @genre, release_year = @releaseYear, platform = @platform where id = @Id",
                new {title = game.Title, genre = game.Genre, releaseYear = game.Release_Year, platform = game.Platform, Id = game.Id});
        }
    }
}
