using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _articleService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result.Message);
        }

        [HttpPost("add")]
        public ActionResult Add(Article article)
        {
            var result = _articleService.Add(article);
            return result.Success ? Ok(result) : BadRequest(result.Message);
        }
        
        [HttpGet("getarticlesofauthor")]
        public ActionResult GetArticlesOfAuthor(int authorCode)
        {
            var result = _articleService.GetAllArticlesByAuthor(authorCode);
            return result.Success ? Ok(result) : BadRequest(result.Message);
        }
    }
}
