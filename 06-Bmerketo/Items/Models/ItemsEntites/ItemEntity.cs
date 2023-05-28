using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _06_Bmerketo.Items.Models.ItemsEntites
{
	public class ItemEntity
	{
		public int Id { get; set; }

		public string Title { get; set; } = null!;

		public string? Description { get; set; }

        public string? ImageName { get; set; }
        public string? ImageUrl { get; set; }


        [Column (TypeName = "money")]
		public decimal? Price { get; set; }

		public ICollection<ItemTagEntity> ItemTags { get; set; } = new HashSet<ItemTagEntity>();
	}
}
