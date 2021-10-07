using System;
using Xunit;
using FluentAssertions;
using Web2;

namespace Test.Web2.Models
{
  public class UserTest
  {
    [Fact]
    public void ShouldCreateUser()
    {
      User user = new User() { Username = "alice" };
      user.Username.Should().Be("alice");
    }
  }
}
