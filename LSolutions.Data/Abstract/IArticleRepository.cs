using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSolutions.Entities.Concrete;
using LSolutions.Shared.Data.Abstract;
using LSolutions.Shared.Entities.Abstract;

namespace LSolutions.Data.Abstract
{
    public interface IArticleRepository:IEntityRepository<Article>
    {
        //Article Add(Article article);
    }
}
