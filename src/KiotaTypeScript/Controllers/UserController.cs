using KiotaTypeScript.Models;
using Microsoft.AspNetCore.Mvc;

namespace KiotaTypeScript.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<UserInfo>> Get()
    {
        return Ok(new List<UserInfo>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Username = "Two"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Username = "Three"
            }
        });
    }

    [HttpGet("{id}")]
    public ActionResult<UserInfo> Get(Guid id)
    {
        return Ok(new UserInfo
        {
            Id = id,
            Username = "Two"
        });
    }

    [HttpPost]
    public ActionResult<UserInfo> Post(UserInfo userInfo)
    {
        return Ok(userInfo);
    }

    [HttpPut("{id}")]
    public ActionResult<UserInfo> Put(Guid id, UserInfo userInfo)
    {
        return Ok(userInfo);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        return Ok();
    }
}