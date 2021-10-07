using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Json;


namespace Web2
{

  [ApiController]
  [Route("users")]
  public class UserController : ControllerBase
  {
    private IUserRepository _repository;

    public UserController(IUserRepository repository)
    {
      _repository = repository;
    }

    [HttpPost]
    public async Task<IActionResult> Create(UserDto userDto)
    {
      var user = await _repository.CreateAsync(userDto);
      return Ok(user);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var users = await _repository.GetAllAsync();
      return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var user = await _repository.GetByIdAsync(id);
      if (user is null) return NotFound();
      return Ok(user);
    }
  }
}
