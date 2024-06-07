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
     
        public void AddGame(Game gameToAdd)
        {
            _conn.Execute("insert into games (title, genre, release_year, platform, ImageURL) values (@title, @genre, @releaseYear, @platform, @imageURL)",
                new { title = gameToAdd.Title, genre = gameToAdd.Genre, releaseYear = gameToAdd.Release_Year, platform = gameToAdd.Platform, ImgURL = gameToAdd.ImgURL });
        }

        public IEnumerable<Game> GetAllGames()
		{
			return _conn.Query<Game>("select * from games");
		}

        public Game GetGame(int id)
        {
            return _conn.QuerySingle<Game>("select * from games where id = @id", new { id = id });
        }

        public void RemoveGame(Game gameToRemove)
        {
            _conn.Execute("DELETE from games where id = @id", new { id = gameToRemove.Id });
        }

        public void UpdateGame(Game game)
        {
            _conn.Execute("update games set title = @title, genre = @genre, release_year = @releaseYear, platform = @platform, ImageURL = @imageURL where id = @Id",
                new {title = game.Title, genre = game.Genre, releaseYear = game.Release_Year, platform = game.Platform, imageURL = game.ImgURL, Id = game.Id });
        }

    }
}
