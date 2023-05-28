using _06_Bmerketo.Accounts.Models.UserEntities;
using Microsoft.AspNetCore.Identity;

namespace _06_Bmerketo.Accounts.Models.Identity;

public class AppUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? CompanyName { get; set; }
    public string? ImageUrl { get; set; }

	public ICollection<UserAddressEntity> UsersAddresses { get; set; } = new HashSet<UserAddressEntity>();
}
