using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web2
{
  public interface IUserRepository
  {
    Task<User> CreateAsync(UserDto userDto);
    Task<IEnumerable<User>> GetAllAsync();
    Task<User> GetByIdAsync(int id);
    Task<User> GetByUsernameAsync(string username);
  }
}
