using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public IResult Add(Article article)
        {
            return new SuccessResult(SuccessMessages.ArticleAdded);
        }

        public IResult Delete(Article article)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Article>> GetAll()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetAll().ToList(), SuccessMessages.ArticlesListed);
        }

        public IDataResult<List<Article>> GetAllArticlesByAuthor(int authorCode)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Article> GetById(int articleId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
