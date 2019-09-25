using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiServer.Entities;
using WebApiServer.Interfaces;

namespace WebApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return new ActionResult<List<User>>(_userRepository.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return new ActionResult<User>(_userRepository.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userRepository.Add(user);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody] User user)
        {
            _userRepository.Update(user);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
