using _06_Bmerketo.Constructs.Contacts.Models.Entites;
using System.ComponentModel.DataAnnotations;

namespace _06_Bmerketo.Constructs.ViewModel
{
	public class ContactFormViewModel
	{
        [Display(Name = "Name")]
        [Required(ErrorMessage = "You must provide a Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Email")]
        [Required(ErrorMessage = "You must provide a Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
		public string? PhoneNumber { get; set; }
		public string? Company { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Atleast 2 letters lenght")]
        public string Message { get; set; } = null!;


        public static implicit operator ContactFormEntity(ContactFormViewModel viewModel)
		{
			return new ContactFormEntity
			{
				Name = viewModel.Name,
				Email = viewModel.Email,
				Message = viewModel.Message
			};
		}



	}
}
