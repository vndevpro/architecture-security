using System.Configuration;
using System.Data.Entity;
using Rabbit.SecurityLayer.Domain;

namespace Rabbit.SecurityLayer.Data
{
    public class SecurityDataContext : DbContext, ISecurityDataContext
    {
        public SecurityDataContext()
            : base("SecurityDb")
        {
        }

        public SecurityDataContext(string connectionStringName)
            : base(ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString)
        {
        }

        public IDbSet<User> Users
        {
            get;
            set;
        }
    }
}
