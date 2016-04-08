using GdNet.Domain.Repository;

namespace Rabbit.SecurityLayer.Domain.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetByProfile(string profile);
    }
}