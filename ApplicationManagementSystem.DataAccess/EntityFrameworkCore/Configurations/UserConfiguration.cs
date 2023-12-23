using ApplicationManagementSystem.Core.Constants;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationManagementSystem.DataAccess.EntityFrameworkCore.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(_user => _user.Id);

            builder.Property(_user => _user.Id).HasColumnOrder(0);

            builder.Property(_user => _user.Name).HasMaxLength(CoreConsts.MaxLength50).IsRequired().HasColumnOrder(1);

            builder.Property(_user => _user.Surname).HasMaxLength(CoreConsts.MaxLength50).HasColumnOrder(2);

            builder.Property(_user => _user.Username).HasMaxLength(CoreConsts.MaxLength50).HasColumnOrder(3);

            builder.Property(_user => _user.Email).HasMaxLength(CoreConsts.MaxLength50).IsRequired().HasColumnOrder(4);

            builder.Property(_user => _user.Password).HasMaxLength(CoreConsts.MaxLength50).HasColumnOrder(5);

            builder.Property(_user => _user.PhoneNumber).HasColumnOrder(6);

            builder.HasData(
                  new User
                  {
                      Id = 1,
                      Name = "Emre",
                      Surname = "Dindar",
                      Username = "emredindr",
                      Email = "emredindr@gmail.com",
                      Password = "asd123",
                      PhoneNumber = "1234567890",
                      Role = UserRole.user
                  },
                new User
                {
                    Id = 2,
                    Name = "DevPatika",
                    Surname = "Kodluyoruz",
                    Username = "kodluyoruz",
                    Email = "kodluyoruz@patika.dev",
                    Password = "bootcamp109",
                    PhoneNumber = "1234567890",
                    Role = UserRole.admin
                });

        }

    }
}