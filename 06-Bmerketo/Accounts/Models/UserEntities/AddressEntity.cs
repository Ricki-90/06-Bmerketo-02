using _06_Bmerketo.Accounts.Models.Identity;

namespace _06_Bmerketo.Accounts.Models.UserEntities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string StreetName { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;

        public ICollection<UserAddressEntity> UsersAddresses { get; set; } = new HashSet<UserAddressEntity>();

    }
}
