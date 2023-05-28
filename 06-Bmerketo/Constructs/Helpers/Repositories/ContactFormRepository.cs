using _06_Bmerketo.Constructs.Contacts.Models.Entites;
using _06_Bmerketo.Database;

namespace _06_Bmerketo.Constructs.Helpers.Repositories
{
	public class ContactFormRepository : RepoAccount<ContactFormEntity>
	{
		public ContactFormRepository(AccountsDB context) : base(context)
		{
		}
	}
}
