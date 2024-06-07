namespace VideoGameMVC.Models
{
	public class Game
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Release_Year { get; set; }
        public string Platform { get; set; }
        public string ImgURL { get; set; }
    }
}
