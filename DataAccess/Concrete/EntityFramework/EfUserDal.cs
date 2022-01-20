using Core.DataAccess.EntityRepository;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal :
        EfEntityRepositoryBase<User, ArticleBlogContext>,
        IUserDal
    {
        public List<ArticleOfUser> GetArticles(User user)
        {
            using (var context = new ArticleBlogContext())
            {
                var result = from articles in context.Articles
                             join users in context.Users
                                on articles.UserCode equals user.UserCode
                             select new ArticleOfUser
                             {
                                 ArticleText = articles.ArticleText,
                                 UserCode = user.UserCode,
                             };
                return result.ToList();
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ArticleBlogContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserCode
                             select new OperationClaim { 
                                 OperationClaimId = operationClaim.OperationClaimId, 
                                 OperationClaimName = operationClaim.OperationClaimName 
                             };
                return result.ToList();
            }
        }

    }
}
