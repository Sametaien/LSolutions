using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSolutions.Data.Abstract;
using LSolutions.Data.Concrete.EntityFramework.Contexts;
using LSolutions.Data.Concrete.EntityFramework.Repositories;

namespace LSolutions.Data.Concrete
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly LSolutionsBlogContexts _context;
        private EfArticleRepository _articleRepository;
        private EfCommentRepository _commentRepository;
        private EfUserRepository _userRepository;
        private EfRoleRepository _roleRepository;
        private EfCatagoryRepository _catagoryRepository;

        public UnitOfWork(LSolutionsBlogContexts context)
        {
            _context = context;
        }



        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);
        public ICatagoryRepository Categories => _catagoryRepository ?? new EfCatagoryRepository(_context);
        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);
        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);
        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
