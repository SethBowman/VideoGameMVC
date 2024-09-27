using Moq;
using VideoGameMVC.Controllers;
using VideoGameMVC.Models;
using VideoGameMVC;
using Microsoft.AspNetCore.Mvc;

public class GamesControllerTests
{
    private readonly Mock<IGameRepo> _mockRepo;
    private readonly GamesController _controller;
    
    public GamesControllerTests()
    {
        _mockRepo = new Mock<IGameRepo>();
        _controller = new GamesController(_mockRepo.Object);
    }
   
    [Fact]
    public void Index_ReturnsViewResult_WithListOfGames()
    {
        _mockRepo.Setup(repo => repo.GetAllGames()).Returns(GetSampleGames());
      
        var result = _controller.Index();
     
        var viewResult = Assert.IsType<ViewResult>(result);
        
        var model = Assert.IsAssignableFrom<IEnumerable<Game>>(viewResult.ViewData.Model);
        Assert.NotNull(model);
        Assert.True(model.Any());
    }

    private List<Game> GetSampleGames()
    {
        return new List<Game>
        {
            new Game { Id = 1, Title = "Game 1", Genre = "Action", Release_Year = 2017, Platform = "PC" },
            new Game { Id = 2, Title = "Game 2", Genre = "RPG", Release_Year = 2018, Platform = "Xbox" },
            new Game { Id = 3, Title = "Game 3", Genre = "Adventure", Release_Year = 2019, Platform = "PS4" }
        };
    }
}
