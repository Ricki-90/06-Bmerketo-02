using _06_Bmerketo.Accounts.Models.Identity;
using Microsoft.EntityFrameworkCore;

namespace _06_Bmerketo.Accounts.Models.UserEntities
{
    [PrimaryKey(nameof(UserId), nameof(AddressId))]
    public class UserAddressEntity
    {
        public string UserId { get; set; } = null!;
        public AppUser User { get; set; } = null!;
        
        public int AddressId { get; set; }
        public AddressEntity Address { get; set; } = null!;


    }
}
