using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IArticleService
    {
        IResult Add(Article article);
        IResult Delete(Article article);
        IResult Update(Article article);

        IDataResult<List<Article>> GetAll();
        IDataResult<List<Article>> GetAllArticlesByAuthor(int authorCode);
        IDataResult<Article> GetById(int articleId);
    }
}
