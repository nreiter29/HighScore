using BLHS.Repos;

namespace BLHS
{
    public interface IUnitOfWork : IDisposable
    {
        public GameRepo Games { get; }
        public PlayerRepo Players { get; }
        int Commit();
        void Rollback();
    }
}
