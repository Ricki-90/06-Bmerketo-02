namespace _06_Bmerketo.Items.Models.ItemsEntites
{
	public class TagEntity
	{
		public int Id { get; set; }
		public string TagName { get; set; } = null!;


		public ICollection<ItemTagEntity> ItemTags { get; set; } = new HashSet<ItemTagEntity>();
	}
}
