using ApplicationManagementSystem.Core.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationManagementSystem.DataAccess.EntityFrameworkCore.Configurations;

public class ApplicationDocumentConfiguration : IEntityTypeConfiguration<ApplicationDocument>
{
    public void Configure(EntityTypeBuilder<ApplicationDocument> builder)
    {
        builder.HasKey(_applicationDocument => _applicationDocument.Id);

        builder.Property(_applicationDocument => _applicationDocument.Id)
            .HasColumnOrder(0);

        builder.Property(_applicationDocument => _applicationDocument.ApplicationId)
            .HasColumnOrder(1)
            .IsRequired();

        builder.Property(_applicationDocument => _applicationDocument.DocumentId)
            .HasColumnOrder(2)
            .IsRequired();
    }
}
