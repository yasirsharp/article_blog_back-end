using Core.DataAccess.EntityRepository;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal :
        EfEntityRepositoryBase<Article, ArticleBlogContext>,
        IArticleDal
    {
    }
}
