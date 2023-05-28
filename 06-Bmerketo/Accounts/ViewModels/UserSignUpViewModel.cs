using _06_Bmerketo.Accounts.Models.Identity;
using _06_Bmerketo.Accounts.Models.UserEntities;
using System.ComponentModel.DataAnnotations;

namespace _06_Bmerketo.Accounts.ViewModels
{
    public class UserSignUpViewModel
    {
        [Display (Name = "First Name")]
        [Required(ErrorMessage = "You must provide a first name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must provide a last name")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Street Name")]
        [Required(ErrorMessage = "You must provide a street name")]
        public string StreetName { get; set; } = null!;

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "You must provide a postal name")]
        public string PostalCode { get; set; } = null!;

        [Display(Name = "City")]
        [Required(ErrorMessage = "You must provide a city")]
        public string City { get; set; } = null!;

        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Company")]
        public string? Company { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "You must provide a Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;


        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must provide a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        [Display(Name = "Comfirm Password")]
        [Required(ErrorMessage = "You must provide a password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;

        [Display(Name = "Upload Profile Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }

        [Display(Name = "I have read an accepts the terms and agreements")]
        [Required(ErrorMessage = "You must provide a first name")]
        public bool TermsAndAgreement { get; set; } = false;


        public static implicit operator AppUser(UserSignUpViewModel model)
        {
            return new AppUser
            {
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                CompanyName = model.Company
                };
        }

        public static implicit operator AddressEntity(UserSignUpViewModel model)
        {
            return new AddressEntity
            {
                StreetName = model.StreetName,
                PostalCode = model.PostalCode,
                City = model.City
            };
        }
    }
}
