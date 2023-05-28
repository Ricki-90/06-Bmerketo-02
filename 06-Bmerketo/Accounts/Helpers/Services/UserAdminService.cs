using _06_Bmerketo.Accounts.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace _06_Bmerketo.Accounts.Helpers.Services;

public class UserAdminService
{
    #region construkt & private fields
    private readonly UserManager<AppUser> _userManager;

    public UserAdminService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    #endregion

    public async Task<IEnumerable<User>> GetUsersAsync()
	{
		var users = new List<User>();
		foreach(var user in await _userManager.Users.ToListAsync())
		{
			var _user = new User
			{
				Id = user.Id,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Email = user.Email
			};

			foreach(var role in await _userManager.GetRolesAsync(user))
			{
				_user.RoleNames.Add(role);
			}

			users.Add(_user);
		}
		return users;
	}
}

public class User
{
	public string? Id { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? Email { get; set; }
	public List<string> RoleNames { get; set; } = new List<string>();

}