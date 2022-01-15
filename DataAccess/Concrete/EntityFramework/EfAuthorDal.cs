using Core.DataAccess.EntityRepository;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAuthorDal :
        EfEntityRepositoryBase<Author, ArticleBlogContext>,
        IAuthorDal { }
}
