using Core.Abstraction.ApplicationService.AccountDomain;
using Core.Abstraction.ApplicationService.ArticleDomain;
using Core.Abstraction.DataAccessLayer;
using Core.DomainModel.ArticleModels;
using Core.DomainModel.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Presentation.WebApi.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IGetArticleService getArticleService;

        public HomeController(IGetArticleService getArticleService)
        {
            this.getArticleService = getArticleService;
        }

        [HttpGet]

        public async Task<ApiResult<IList<Article>>> Index()
        {
            var result = (await getArticleService.GetAll()).Data;
            return result;
        }

        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
