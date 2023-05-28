using Microsoft.EntityFrameworkCore;

namespace _06_Bmerketo.Items.Models.ItemsEntites
{
	[PrimaryKey("ItemId", "TagId")]
	public class ItemTagEntity
	{
		public int ItemId { get; set; }
		public ItemEntity Item { get; set; } = null!;
		public int TagId { get; set; }
		public TagEntity Tag { get; set; } = null!;
	}
}
