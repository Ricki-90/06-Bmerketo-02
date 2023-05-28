using _06_Bmerketo.Accounts.Models.UserEntities;
using _06_Bmerketo.Constructs.Helpers.Repositories;
using _06_Bmerketo.Database;


namespace _06_Bmerketo.Accounts.Helpers.Repositories
{
    public class UserAddressRepository : RepoAccount<UserAddressEntity>
    {
        public UserAddressRepository(AccountsDB context) : base(context)
        {
        }
    }
}
