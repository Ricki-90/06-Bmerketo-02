using _06_Bmerketo.Constructs.Helpers.Repositories;
using _06_Bmerketo.Databases;
using _06_Bmerketo.Items.Models.ItemsEntites;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _06_Bmerketo.Items.Helpers.Repositories
{
	public class ItemRepository : RepoItem<ItemEntity>
	{
        #region construkt & private fields
        private readonly ItemsDB __context;

        public ItemRepository(ItemsDB context) : base(context)
        {
            __context = context;
        }
        #endregion

        public override async Task<IEnumerable<ItemEntity>> GetAllAsync()
		{
			var items = await __context.Item.Include(x => x.ItemTags).ThenInclude(x => x.Tag).ToListAsync();
			return items!;
		}

		public override async Task<ItemEntity> GetAsync(Expression<Func<ItemEntity, bool>> expression)
		{
			var item = await __context.Item.Include(x => x.ItemTags).ThenInclude(x => x.Tag).FirstOrDefaultAsync(expression);
			return item!;
		}
	}
}
