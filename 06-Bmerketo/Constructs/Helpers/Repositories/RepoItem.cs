using _06_Bmerketo.Databases;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace _06_Bmerketo.Constructs.Helpers.Repositories
{
	public abstract class RepoItem<TEntity> where TEntity : class
	{
		private readonly ItemsDB __context;

		protected RepoItem(ItemsDB context)
		{
			__context = context;
		}

		public virtual async Task<TEntity> AddAsync(TEntity entity)
		{
			try
			{
				__context.Set<TEntity>().Add(entity);
				await __context.SaveChangesAsync();
				return entity;
			}
			catch (Exception ex) { Debug.WriteLine(ex.Message); }
			return null!;
		}

		public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
		{
			try
			{
				var entity = await __context.Set<TEntity>().FirstOrDefaultAsync(expression);
				if (entity != null)
					return entity;
			}
			catch (Exception ex) { Debug.WriteLine(ex.Message); }
			return null!;
		}

		public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			try
			{
				var entities = await __context.Set<TEntity>().ToListAsync();
				if (entities != null)
					return entities;
			}
			catch (Exception ex) { Debug.WriteLine(ex.Message); }
			return null!;
		}
	}
}
