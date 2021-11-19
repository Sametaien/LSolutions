using LSolutions.Data.Abstract;
using LSolutions.Entities.Concrete;
using LSolutions.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace LSolutions.Data.Concrete.EntityFramework.Repositories
{
    public class EfRoleRepository:EfEntityRepositoryBase<Role>,IRoleRepository
    {
        public EfRoleRepository(DbContext context) : base(context)
        {

        }
    }
}
