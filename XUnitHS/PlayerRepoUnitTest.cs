using BLHS.Repos;
using DALHS;
using DTOsHS;
using ModelsHS;
using Moq;

namespace XUnitHS
{
    public class PlayerRepoUnitTest : IDisposable
    {
        Mock<IDal> mockDal;

        PlayerRepo playerRepo
        {
            get => new PlayerRepo(mockDal.Object);
        }

        public PlayerRepoUnitTest()
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
        public void GetPlayers_ReturnsActivePlayers()
        {
            mockDal.Setup(d => d.Players).Returns(new List<Player>
            {
                new Player { PlayerId = 1, FName = "John", LName = "Doe", Exit = null },
                new Player { PlayerId = 2, FName = "Jane", LName = "Doe", Exit = DateTime.Now.AddDays(1) },
                new Player { PlayerId = 3, FName = "Jim", LName = "Doe", Exit = DateTime.Now.AddDays(-1) },
            });

            var result = playerRepo.GetPlayers();

            Assert.Equal(2, result.Count);
            Assert.Contains(result, r => r.FullName == "John Doe");
            Assert.Contains(result, r => r.FullName == "Jane Doe");
        }

        [Fact]
        public void GetPlayer_ReturnsPlayer_WhenPlayerExists()
        {
            var existingPlayer = new Player { PlayerId = 1, FName = "John", LName = "Doe" };
            mockDal.Setup(d => d.Players).Returns(new List<Player> { existingPlayer });

            var result = playerRepo.GetPlayer(1);

            Assert.NotNull(result);
            Assert.Equal("John Doe", result.FName + " " + result.LName);
        }

        [Fact]
        public void GetPlayer_ReturnsNull_WhenPlayerDoesNotExist()
        {
            mockDal.Setup(d => d.Players).Returns(new List<Player>());

            var result = playerRepo.GetPlayer(1);

            Assert.Null(result);
        }

        [Fact]
        public void Add_ReturnsTrue_WhenPlayerIsAdded()
        {
            mockDal.Setup(d => d.Players).Returns(new List<Player>
            {
                new Player { PlayerId = 1, FName = "John", LName = "Doe" }
            });
            var newPlayer = new PlayerAdd { PlayerId = 2, FName = "John", LName = "Doe" };

            var result = playerRepo.Add(newPlayer);

            Assert.True(result);
            Assert.Equal(2, mockDal.Object.Players.Count);
        }

        [Fact]
        public void Update_ReturnsTrue_WhenPlayerExists()
        {
            var existingPlayer = new Player { PlayerId = 1, FName = "John", LName = "Doe", Exit = null };
            mockDal.Setup(d => d.Players).Returns(new List<Player> { existingPlayer });
            var playerDetail = new PlayerDetail { PlayerId = 1, FName = "Jane", LName = "Doe" };

            var result = playerRepo.Update(playerDetail);

            Assert.True(result);
            Assert.Equal("Jane Doe", playerDetail.FName + " " + playerDetail.LName);
        }

        [Fact]
        public void Update_ReturnsFalse_WhenPlayerDoesNotExist()
        {
            mockDal.Setup(d => d.Players).Returns(new List<Player>());
            var playerDetail = new PlayerDetail { PlayerId = 1, FName = "Jane", LName = "Doe" };

            var result = playerRepo.Update(playerDetail);

            Assert.False(result);
        }

        [Fact]
        public void DeleteWithId_ReturnsTrue_WhenPlayerExists()
        {
            mockDal.Setup(d => d.Players).Returns(new List<Player>
            {
                new Player { PlayerId = 1, FName = "John", LName = "Doe" },
                new Player { PlayerId = 2, FName = "Jane", LName = "Doe" },
            });

            var result = playerRepo.Delete(1);

            Assert.True(result);
            Assert.Single(mockDal.Object.Players);
        }

        [Fact]
        public void DeleteWithId_ReturnsFalse_WhenPlayerDoesNotExist()
        {
            mockDal.Setup(d => d.Players).Returns(new List<Player>());

            var result = playerRepo.Delete(1);

            Assert.False(result);
        }

        [Fact]
        public void DeleteWithPlayer_ReturnsTrue_WhenGameExists()
        {
            // Arrange
            var existingGame = new Player { PlayerId = 1, FName = "John", LName = "Doe" };
            mockDal.Setup(d => d.Players).Returns(new List<Player>
            {
                existingGame,
                new Player { PlayerId = 2, FName = "Jane", LName = "Doe" },
            });

            // Act
            var result = playerRepo.Delete(existingGame);

            // Assert
            Assert.True(result);
            Assert.Single(mockDal.Object.Players);
        }

        [Fact]
        public void DeleteWithPlayer_ReturnsFalse_WhenGameDoesNotExist()
        {
            // Arrange
            var nonExistingPlayer = new Player { PlayerId = 1, FName = "John", LName = "Doe" };
            mockDal.Setup(d => d.Players).Returns(new List<Player>());

            // Act
            var result = playerRepo.Delete(nonExistingPlayer);

            // Assert
            Assert.False(result);
        }
    }
}
