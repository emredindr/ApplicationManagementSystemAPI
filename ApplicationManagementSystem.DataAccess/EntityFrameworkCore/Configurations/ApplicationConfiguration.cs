using ApplicationManagementSystem.Core.Constants;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ApplicationManagementSystem.DataAccess.EntityFrameworkCore.Configurations;

public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.HasKey(_application => _application.Id);

        builder.Property(_application => _application.Id)
         .HasColumnOrder(0);

        builder.Property(_application => _application.FirstName)
            .HasColumnOrder(1)
            .IsRequired();

        builder.Property(_application => _application.LastName)
           .HasColumnOrder(2)
           .IsRequired();

        builder.Property(_application => _application.Email)
           .HasColumnOrder(3);

        builder.Property(_application => _application.Birthday)
            .IsRequired()
            .HasColumnOrder(4);

        builder.Property(_application => _application.IdentityNumber)
            .HasColumnOrder(5);

        builder.Property(_application => _application.Reason)
            .HasDefaultValue(string.Empty)
            .HasColumnOrder(6);

        builder.Property(_application => _application.Address)
           .HasColumnOrder(7);

        builder.Property(_application => _application.Status)
            .HasDefaultValue(ApplicationStatus.Pending)
        .HasColumnOrder(8);

        builder.Property(_application => _application.CreationTime).
            HasColumnOrder(9);

        builder.Property(_application => _application.LastModifierUserId).
            HasColumnOrder(10);

        builder.Property(_application => _application.LastModifierUserId).
            HasColumnOrder(11);

        builder.Property(_application => _application.DeletorUserId).
            HasColumnOrder(12);

        builder.Property(_application => _application.DeletionTime).
           HasColumnOrder(13);

        builder.Property(_application => _application.IsDeleted)
            .HasColumnOrder(14);

    }
}
