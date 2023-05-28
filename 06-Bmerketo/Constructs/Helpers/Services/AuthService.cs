using _06_Bmerketo.Accounts.Helpers.Services;
using _06_Bmerketo.Accounts.Models.Identity;
using _06_Bmerketo.Accounts.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _06_Bmerketo.Constructs.Helpers.Services;

public class AuthService
{
    #region construkt & private fields
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly AddressService _addressService;

    public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AddressService addressService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _addressService = addressService;
    }
    #endregion

    public async Task<bool> RegisterAsync(UserSignUpViewModel viewModel)
	{
		try
		{
			//Create User
			var result = await _userManager.CreateAsync(viewModel, viewModel.Password);
			if (result.Succeeded)
			{
				//Add user to role
				var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email);
				await _userManager.AddToRoleAsync(user!, "user");


				//Create Address and add user address
				var address = await _addressService.GetOrCreateAsync(viewModel);

				return await _addressService.AddUserAddress(user!.Id, address.Id);
		
			}
		}
		catch (Exception ex) { Debug.WriteLine(ex.Message); }
		return false;
	}

	public async Task<bool> LoginAsync(UserSignInViewModel viewModel)
	{
		try
		{
			var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false );
			return result.Succeeded;
		}
		catch (Exception ex) { Debug.WriteLine(ex.Message); }
		return false;
	}



	public async Task<bool> LogoutAsync()
	{
		try
		{
			await _signInManager.SignOutAsync();
			return true;
		}
		catch (Exception ex) { Debug.WriteLine(ex.Message); }
		return false;
	}

}
