using _06_Bmerketo.Accounts.Helpers.Repositories;
using _06_Bmerketo.Accounts.Models.Identity;
using _06_Bmerketo.Accounts.Models.UserEntities;
using System.Diagnostics;

namespace _06_Bmerketo.Accounts.Helpers.Services;

public class AddressService
{
    #region construkt & private fields
    private readonly AddressRepository _addressRepository;
    private readonly UserAddressRepository _userAddressRepository;

    public AddressService(AddressRepository addressRepository, UserAddressRepository userAddressRepository)
    {
        _addressRepository = addressRepository;
        _userAddressRepository = userAddressRepository;
    }
    #endregion


    public async Task<AddressEntity> GetOrCreateAsync(AddressEntity entity)
    {
        var _entity = await _addressRepository.GetAsync(x =>
            x.StreetName == entity.StreetName &&
            x.PostalCode == entity.PostalCode &&
            x.City == entity.City
        );

            _entity ??= await _addressRepository.AddAsync(entity);
            return entity!;
    }

    public async Task<bool> AddUserAddress(string userId, int addressId)
    {
        try
        {
            var entity = await _userAddressRepository.AddAsync(new UserAddressEntity
            {
                UserId = userId,
                AddressId = addressId
            });

            if (entity != null)
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message);  }
        return false;
    }
}
