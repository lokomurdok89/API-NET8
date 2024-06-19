using Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Application;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLiveController : ControllerBase
    {
        private readonly IUserTask _us;



        // GET: TestLiveController
        public TestLiveController(Application.IUserTask us)
        {
            _us = us;
        }
       

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _us.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(Guid id)
        {
            return _us.Get(id);
        }

        [HttpPost]
        public ActionResult<User> AddUser(User user)
        {
            return _us.AddUser(user);
        }


    }
}
