using BLHS.Repos;
using DALHS;
using ModelsHS;
using Moq;

namespace XUnitHS
{
    public class HighScoreRepoUnitTest : IDisposable
    {
        Mock<IDal> mockDal;

        HighScoreRepo highScoreRepo
        {
            get => new HighScoreRepo(mockDal.Object);
        }

        public HighScoreRepoUnitTest()
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
        public void GetHighscores_ReturnsAllHighscores()
        {
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
            {
                new HighScore { PlayerId = 1, GameId = 1, Score = 100, Created = DateTime.Now },
                new HighScore { PlayerId = 2, GameId = 1, Score = 200, Created = DateTime.Now },
            });

            var result = highScoreRepo.GetHighScores();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetHighscoresByGame_ReturnsHighscoresForSpecificGame()
        {
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
            {
                new HighScore { PlayerId = 1, GameId = 1, Score = 100, Created = DateTime.Now },
                new HighScore { PlayerId = 2, GameId = 2, Score = 200, Created = DateTime.Now },
            });

            var result = highScoreRepo.GetHighScoresByGame(1);

            Assert.Single(result);
        }

        [Fact]
        public void GetHighscoresByPlayer_ReturnsHighscoresForSpecificPlayer()
        {
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
            {
                new HighScore { PlayerId = 1, GameId = 1, Score = 100, Created = DateTime.Now },
                new HighScore { PlayerId = 1, GameId = 2, Score = 200, Created = DateTime.Now },
            });

            var result = highScoreRepo.GetHighScoresByPlayer(1);

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void Add_ReturnsTrue_WhenHighScoreIsAdded()
        {
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
            {
                new HighScore { PlayerId = 1, GameId = 1, Score = 100 },
            });
            var newHighScore = new HighScore { PlayerId = 2, GameId = 2, Score = 100 };

            var result = highScoreRepo.Add(newHighScore);

            Assert.True(result);
            Assert.Equal(2, mockDal.Object.HighScores.Count);
        }

        [Fact]
        public void Update_ReturnsTrue_WhenHighScoreExists()
        {
            var existingHighScore = new HighScore { PlayerId = 1, GameId = 1, Score = 100, Created = DateTime.Now };
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
            {
                existingHighScore,
            });
            var highScore = new HighScore { PlayerId = 1, GameId = 1, Score = 200, Created = DateTime.Now };

            var result = highScoreRepo.Update(highScore);

            Assert.True(result);
            Assert.Equal(200, mockDal.Object.HighScores[0].Score);
        }

        [Fact]
        public void Update_ReturnsFalse_WhenHighScoreDoesNotExist()
        {
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>());
            var highScore = new HighScore { PlayerId = 1, GameId = 1, Score = 200, Created = DateTime.Now };

            var result = highScoreRepo.Update(highScore);

            Assert.False(result);
        }

        [Fact]
        public void DeleteWithId_ReturnsTrue_WhenHighScoreExists()
        {
            var existingHighScore = new HighScore { PlayerId = 1, GameId = 1, Score = 100, Created = DateTime.Now };
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
            {
                existingHighScore,
                new HighScore { PlayerId = 2, GameId = 1, Score = 100, Created = DateTime.Now },
            });

            var result = highScoreRepo.Delete(1, 1);

            Assert.True(result);
            Assert.Single(mockDal.Object.HighScores);
        }

        [Fact]
        public void DeleteWithId_ReturnsFalse_WhenHighScoreDoesNotExist()
        {
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>());

            var result = highScoreRepo.Delete(1, 1);

            Assert.False(result);
            Assert.Empty(mockDal.Object.HighScores);
        }

        [Fact]
        public void DeleteWithHighScore_ReturnsTrue_WhenGameExists()
        {
            // Arrange
            var existingHighScore = new HighScore { PlayerId = 1, GameId = 1, Score = 100, Created = DateTime.Now };
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>
            {
                existingHighScore,
                new HighScore { PlayerId = 2, GameId = 1, Score = 100, Created = DateTime.Now },
            });

            // Act
            var result = highScoreRepo.Delete(existingHighScore);

            // Assert
            Assert.True(result);
            Assert.Single(mockDal.Object.HighScores);
        }

        [Fact]
        public void DeleteWithHighScore_ReturnsFalse_WhenGameDoesNotExist()
        {
            // Arrange
            var nonExistingHighScore = new HighScore { PlayerId = 1, GameId = 1, Score = 100, Created = DateTime.Now };
            mockDal.Setup(d => d.HighScores).Returns(new List<HighScore>());

            // Act
            var result = highScoreRepo.Delete(nonExistingHighScore);

            // Assert
            Assert.False(result);
        }
    }
}
