using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    // Created interface to the repository using generic typing
    public interface IEntityRepository<TEntity>
        where TEntity : Entity
    {
        TEntity GetByID(Guid id);
    }
}
