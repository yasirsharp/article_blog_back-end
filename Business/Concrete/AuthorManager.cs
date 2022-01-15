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
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal autherDal)
        {
            _authorDal = autherDal;
        }

        public IResult Add(Author author)
        {
            _authorDal.Add(author);
            return new SuccessResult(SuccessMessages.AuthorAdded);
        }

        public IResult Delete(Author author)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Author>> GetAllAuthors()
        {
            var result = _authorDal.GetAll();
            return new SuccessDataResult<List<Author>>(result.ToList(), SuccessMessages.AuthorsListed);
        }

        public IDataResult<Author> GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Author> GetAuthorByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
