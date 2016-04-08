using GdNet.Data.EF;
using GdNet.Data.EF.Strategies;
using Rabbit.SecurityLayer.Domain;
using Rabbit.SecurityLayer.Domain.Repositories;
using System.Data.Entity;

namespace Rabbit.SecurityLayer.Data.Repositories
{
    public class UserRepository : EfRepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbSet<User> entities)
            : base(entities)
        {
        }

        public UserRepository(IDbSet<User> entities, ISavingStrategy savingStrategy, IDeletionStrategy<User> deletionStrategy)
            : base(entities, savingStrategy, deletionStrategy)
        {
        }

        public User GetByProfile(string profile)
        {
            return GetByFilter(x => x.Profile == profile);
        }
    }
}