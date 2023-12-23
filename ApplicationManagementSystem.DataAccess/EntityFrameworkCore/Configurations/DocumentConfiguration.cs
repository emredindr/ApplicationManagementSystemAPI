﻿using ApplicationManagementSystem.Core.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationManagementSystem.DataAccess.EntityFrameworkCore.Configurations;

public class DocumentConfiguration : IEntityTypeConfiguration<Document>
{
    public void Configure(EntityTypeBuilder<Document> builder)
    {
        builder.HasKey(_document => _document.Id);

        builder.Property(_document => _document.Id)
            .HasColumnOrder(0);

        builder.Property(_document => _document.Url)
          .HasColumnOrder(1)
          .IsRequired();
    }
}
