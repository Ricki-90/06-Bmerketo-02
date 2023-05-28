using _06_Bmerketo.Constructs.Helpers.Repositories;
using _06_Bmerketo.Database;
using _06_Bmerketo.Databases;
using _06_Bmerketo.Items.Models.ItemsEntites;

namespace _06_Bmerketo.Items.Helpers.Repositories
{
	public class ItemTagRepository : RepoItem<ItemTagEntity>
	{
		public ItemTagRepository(ItemsDB context) : base(context)
		{
		}
	}
}
