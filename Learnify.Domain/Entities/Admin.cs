using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class Admin : BaseEntity
{
    public string Username { get; set; }

    public string Password { get; set; }
}
