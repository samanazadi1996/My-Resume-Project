using Core.Abstraction.ApplicationService.AccountDomain;
using Core.Abstraction.DataAccessLayer;
using Core.DomainModel.ArticleModels;
using Core.DomainModel.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Endpoint.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUnitOfWork<Article> unitOfWork;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IAccountService accountService;

        public HomeController(IUnitOfWork<Article> unitOfWork, UserManager<ApplicationUser> userManager, IAccountService accountService)
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.accountService = accountService;
        }
        // GET: api/<HomeController>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var op = await accountService.GetUserByUserName("admin@admin.com");
            var ppp = userManager.Users.Include(p => p.Articles).ToList();
            var appp = unitOfWork.Repository.Get().Include(p => p.ApplicationUser).ToList();

            return new string[] { "value1", "value2" };
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
