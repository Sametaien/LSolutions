using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSolutions.Shared.Entities.Abstract;

namespace LSolutions.Entities.Concrete
{
    public class Role:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Descripton { get; set; }
        public ICollection<User> User { get; set; }
    }
}
