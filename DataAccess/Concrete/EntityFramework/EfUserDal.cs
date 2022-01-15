using Core.DataAccess.EntityRepository;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : 
        EfEntityRepositoryBase<User, ArticleBlogContext>, 
        IUserDal { }
}
