using _06_Bmerketo.Accounts.Models.Identity;
using _06_Bmerketo.Accounts.Models.UserEntities;
using _06_Bmerketo.Constructs.Contacts.Models.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _06_Bmerketo.Database;

public class AccountsDB : IdentityDbContext<AppUser>
{
    #region EntitySet
    public AccountsDB(DbContextOptions<AccountsDB> options) : base(options)
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<UserAddressEntity> UsersAddresses { get; set; }
    public DbSet<ContactFormEntity> ContactForm { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
        new IdentityRole
        {
            Id = "9cd63817-dbb2-453b-8537-25c5e22c4d42",
            Name = "Admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString(),

        },

        new IdentityRole
        {
            Id = "8b45865c-8a5f-4d16-b6fb-3f0407774e62",
			Name = "User",
            NormalizedName = "USER",
            ConcurrencyStamp = Guid.NewGuid().ToString(),

        });

        var passwordHasher = new PasswordHasher<AppUser>();
        var adminUser = new AppUser
		{
			Id = "9fbca2c6-5ba9-4f9d-8f42-30245653861e",
			UserName = "admin@merketo.com",
			NormalizedUserName = "ADMIN@MERKETO.COM",
			Email = "admin@merketo.com",
			NormalizedEmail = "ADMIN@MERKETO.COM",
            ConcurrencyStamp = Guid.NewGuid().ToString()
		};
        adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Merketo123!");
        builder.Entity<AppUser>().HasData(adminUser);


        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            UserId = adminUser.Id,
            RoleId = "9cd63817-dbb2-453b-8537-25c5e22c4d42"
		});
    }
}
