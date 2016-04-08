using System.Data.Entity;
using Rabbit.SecurityLayer.Domain;

namespace Rabbit.SecurityLayer.Data
{
    public interface ISecurityDataContext
    {
        IDbSet<User> Users { get; set; }

        int SaveChanges();
    }
}