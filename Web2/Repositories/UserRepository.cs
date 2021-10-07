using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Web2
{
  public class UserRepository : IUserRepository
  {
    private Database _db;

    public UserRepository(Database db)
    {
      _db = db;
    }

    public async Task<User> CreateAsync(UserDto userDto)
    {
      string microGuid = String.Join("", Guid.NewGuid().ToString().Take(8));
      var user = new User() { Username = $"{userDto.Username}-{microGuid}" };
      await _db.AddAsync(user);
      await _db.SaveChangesAsync();
      return user;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
      return await _db.Users.ToListAsync();
    }

    public async Task<User> GetByIdAsync(int id)
    {
      return await _db.Users.Where(u => u.Id == id).SingleOrDefaultAsync();
    }

    public async Task<User> GetByUsernameAsync(string username)
    {
      return await _db.Users.Where(u => u.Username == username).SingleOrDefaultAsync();
    }
  }
}
