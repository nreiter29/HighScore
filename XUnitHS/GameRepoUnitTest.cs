using BLHS.Repos;
using DALHS;
using DTOsHS;
using ModelsHS;
using Moq;

namespace XUnitHS;

public class GameRepoUnitTest : IDisposable
{
    Mock<IDal> mockDal;

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

    [Fact]
    public void Add_ReturnsTrue_WhenGameDetailIsValid()
    {
        // Arrange
        mockDal.Setup(d => d.Games).Returns(new List<Game>
        {
            new Game { GameId = 1, Title = "Game 1" },
        });

        var gameDetail = new GameDetail
        {
            Title = "Test Game",
            Publisher = "Test Publisher",
            ReleaseDate = DateOnly.FromDateTime(DateTime.Today),
            Notes = "Test Notes",
            Entry = DateTime.Now,
            Exit = null,
            GameId = 2,
        };

        // Act
        var result = gameRepo.Add(gameDetail);

        // Assert
        Assert.True(result);
        Assert.Equal(2, mockDal.Object.Games.Count);
    }

    [Fact]
    public void Add_ReturnsFalse_WhenGameDetailIsNull()
    {
        // Arrange
        GameDetail gameDetail = null;

        // Act
        var result = gameRepo.Add(gameDetail);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void GetGameSelect_ReturnsGamesWithFutureExitDates()
    {
        // Arrange
        mockDal.Setup(d => d.Games).Returns(new List<Game>
        {
            new Game { GameId = 1, Title = "Game 1", Exit = DateTime.Now.AddDays(1) },
            new Game { GameId = 2, Title = "Game 2", Exit = DateTime.Now.AddDays(2) },
            new Game { GameId = 3, Title = "Game 3", Exit = DateTime.Now.AddDays(-1) },
        });

        // Act
        var result = gameRepo.GetGameSelect();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains(result, r => r.DisplayMember == "Game 1");
        Assert.Contains(result, r => r.DisplayMember == "Game 2");
    }

    [Fact]
    public void Update_ReturnsTrue_WhenGameExists()
    {
        // Arrange
        var existingGame = new Game { GameId = 1, Title = "Existing Game" };
        mockDal.Setup(d => d.Games).Returns(new List<Game> { existingGame });
        var gameDetail = new GameDetail { GameId = 1, Title = "Updated Game" };

        // Act
        var result = gameRepo.Update(gameDetail);

        // Assert
        Assert.True(result);
        Assert.Equal("Updated Game", existingGame.Title);
    }

    [Fact]
    public void Update_ReturnsFalse_WhenGameDoesNotExist()
    {
        // Arrange
        mockDal.Setup(d => d.Games).Returns(new List<Game>());
        var gameDetail = new GameDetail { GameId = 1, Title = "Nonexistent Game" };

        // Act
        var result = gameRepo.Update(gameDetail);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void DeleteWithGameId_ReturnsTrue_WhenGameExists()
    {
        // Arrange
        mockDal.Setup(d => d.Games).Returns(new List<Game>
        {
            new Game { GameId = 1, Title = "Existing Game" },
            new Game { GameId = 2, Title = "Test Game" },
        });

        // Act
        var result = gameRepo.Delete(1);

        // Assert
        Assert.True(result);
        Assert.Single(mockDal.Object.Games);
    }

    [Fact]
    public void DeleteWithGameId_ReturnsFalse_WhenGameDoesNotExist()
    {
        // Arrange
        mockDal.Setup(d => d.Games).Returns(new List<Game>());

        // Act
        var result = gameRepo.Delete(1);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void DeleteWithGame_ReturnsTrue_WhenGameExists()
    {
        // Arrange
        var existingGame = new Game { GameId = 1, Title = "Existing Game" };
        mockDal.Setup(d => d.Games).Returns(new List<Game>
        {
            existingGame,
            new Game { GameId = 2, Title = "Test Game" },
        });

        // Act
        var result = gameRepo.Delete(existingGame);

        // Assert
        Assert.True(result);
        Assert.Single(mockDal.Object.Games);
    }

    [Fact]
    public void DeleteWithGame_ReturnsFalse_WhenGameDoesNotExist()
    {
        // Arrange
        var nonExistingGame = new Game { GameId = 1, Title = "Nonexistent Game" };
        mockDal.Setup(d => d.Games).Returns(new List<Game>());

        // Act
        var result = gameRepo.Delete(nonExistingGame);

        // Assert
        Assert.False(result);
    }
}
