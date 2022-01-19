using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Dto;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        List<ArticleOfUser> GetArticles(User user);
    }
}
