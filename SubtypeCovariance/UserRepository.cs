using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    // Implements the new interface
    public class UserRepository : IEntityRepository<User>
    {
        //public override Entity GetByID(Guid id)
        // modified : Do not need to override because using the interface
        public User GetByID(Guid id)
        {
            return new User(id);
        }
    }
}
