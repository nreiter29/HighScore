using BLHS.Repos;
using DALHS;
using DTOsHS;

namespace BLHS
{
    public class UnitOfWork : IUnitOfWork
    {
        IDal _dal;
        GameRepo? _gameRepo;
        PlayerRepo? _playerRepo;

        public UnitOfWork(DalType dalType)
        {
            _dal = dalType switch
            {
                DalType.json => new DalJson(),
                DalType.xml => new DalXml(),
                _ => new DalCsv()
            };
        }

        public GameRepo Games => _gameRepo ??= new GameRepo(_dal);
        public PlayerRepo Players => _playerRepo ??= new PlayerRepo(_dal);

        public int Commit()
        {
            return _dal.Save();
        }

        public void Rollback()
        {
            _dal.Rollback();
        }

        public void Dispose()
        {
        }
    }
}
