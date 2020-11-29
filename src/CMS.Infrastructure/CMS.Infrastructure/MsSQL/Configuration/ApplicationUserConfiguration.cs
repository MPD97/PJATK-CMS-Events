﻿using CMS.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.MsSQL.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(user => user.Purchases)
                .WithOne(purchase => purchase.User)
                .HasForeignKey(purchase => purchase.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
