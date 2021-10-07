using System;
using Xunit;
using FluentAssertions;
using Web1;

namespace Test.Web1.Models
{
  public class MessageTest
  {
    [Fact]
    public void ShouldCreateMessage()
    {
      Message message = new Message() { FromUsername = "bob", ToUsername = "sara", Text = "hey" };
      message.FromUsername.Should().Be("bob");
      message.ToUsername.Should().Be("sara");
      message.Text.Should().Be("hey");
    }
  }
}
