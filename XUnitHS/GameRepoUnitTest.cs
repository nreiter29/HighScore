using BLHS.Repos;
using DALHS;
using ModelsHS;
using Moq;

namespace XUnitHS;

public class GameRepoUnitTest : IDisposable
{
    private Mock<IDal> mockDal;

    GameRepo gameRepo
    {
        get => new GameRepo(mockDal.Object);
    }
    
    public GameRepoUnitTest()
    {
        Setup();
    }

    private void Setup()
    {
        mockDal = new Mock<IDal>();
    }

    public void Dispose()
    {
        // Cleanup mockDal
        mockDal.Reset();
    }

    [Fact]
    public void GetGamesByPlayer_ReturnsCorrectGames_WhenPlayerHasHighScores()
    {
        // Arrange
        mockDal.Setup(d => d.Games).Returns(new List<Game>
        {
            new Game { GameId = 1, Title = "Game 1" },
            new Game { GameId = 2, Title = "Game 2" },
        });

        mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
        {
            new HighScore { GameId = 1, PlayerId = 1 },
            new HighScore { GameId = 2, PlayerId = 1 },
        });
        
        // Act
        var result = gameRepo.GetGamesByPlayer(1);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("Game 1", result[0].Title);
        Assert.Equal("Game 2", result[1].Title);
    }

    [Fact]
    public void GetGamesByPlayer_ReturnsEmptyList_WhenPlayerHasNoHighScores()
    {
        // Arrange
        mockDal.Setup(d => d.Games).Returns(new List<Game>
        {
            new Game { GameId = 1, Title = "Game 1" },
            new Game { GameId = 2, Title = "Game 2" },
        });

        mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
        {
            new HighScore { GameId = 1, PlayerId = 2 },
            new HighScore { GameId = 2, PlayerId = 2 },
        });

        // Act
        var result = gameRepo.GetGamesByPlayer(1);

        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void GetGames_ReturnsGames()
    {
        // Arrange
        mockDal.Setup(d => d.Games).Returns(new List<Game>
        {
            new Game { GameId = 1, Title = "Game 1", Exit = null },
            new Game { GameId = 2, Title = "Game 2", Exit = null },
        });

        // Act
        var result = gameRepo.GetGames();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal(1, result[0].GameId);
        Assert.Equal(2, result[1].GameId);
    }
}
