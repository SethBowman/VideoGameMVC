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
	}
}
