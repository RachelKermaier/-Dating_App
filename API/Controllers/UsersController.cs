using System;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
 [ApiController]

 [Route ("api/[controller]")]
public class UsersController(DataContext context): ControllerBase
{
    
  [HttpGet]
  public async Task<ActionResult<IEnumerable<AppUser>>> GetUser()
  {
    var users = await context.Users.ToListAsync();
    return users;
  }

    [HttpGet("{id}")]
    public ActionResult <AppUser> GetUser(int id)
    {
    var user = context.Users.Find(id);

    if (user == null) return NotFound(); 
    return user;
    }
}
