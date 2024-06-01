using Microsoft.AspNetCore.Identity;

namespace foodies_api.Data;

public class User : IdentityUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }  
    public string Password { get; set; }
}