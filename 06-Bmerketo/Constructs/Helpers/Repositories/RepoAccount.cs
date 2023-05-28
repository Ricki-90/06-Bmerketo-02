using _06_Bmerketo.Database;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace _06_Bmerketo.Constructs.Helpers.Repositories;

public abstract class RepoAccount<TEntity> where TEntity : class
{
	private readonly AccountsDB _context;

	protected RepoAccount(AccountsDB context)
	{
		_context = context;
	}

	public virtual async Task<TEntity> AddAsync(TEntity entity)
	{
		try
		{
			_context.Set<TEntity>().Add(entity);
			await _context.SaveChangesAsync();
			return entity;
		}
		catch (Exception ex) {Debug.WriteLine(ex.Message); }
		return null!;
	}

	public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
	{
		try
		{
			var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
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
			var entities = await _context.Set<TEntity>().ToListAsync();
			if (entities != null)
				return entities;
		}
		catch (Exception ex) { Debug.WriteLine(ex.Message); }
		return null!;
	}
}
