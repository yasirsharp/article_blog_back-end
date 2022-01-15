using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        IResult Add(Author author);
        IResult Update(Author author);
        IResult Delete(Author author);

        IDataResult<List<Author>> GetAllAuthors();
        IDataResult<Author> GetAuthorById(int id);
        IDataResult<Author> GetAuthorByUserId(int id);
    }
}
