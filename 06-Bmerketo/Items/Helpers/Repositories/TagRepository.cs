using _06_Bmerketo.Constructs.Helpers.Repositories;
using _06_Bmerketo.Databases;
using _06_Bmerketo.Items.Models.ItemsEntites;

namespace _06_Bmerketo.Items.Helpers.Repositories
{
	public class TagRepository : RepoItem<TagEntity>
	{
		public TagRepository(ItemsDB context) : base(context)
		{
		}
	}
}
