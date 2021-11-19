using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSolutions.Shared.Entities.Abstract;

namespace LSolutions.Entities.Concrete
{
    public class User:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
