using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Dto;

namespace DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
    }
}
