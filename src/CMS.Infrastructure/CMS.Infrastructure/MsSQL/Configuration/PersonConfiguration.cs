using CMS.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.MsSQL.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(person => person.ID);

            builder.Property(person => person.FirstName)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(person => person.SecondName)
                .HasMaxLength(80)
                .IsRequired(false);

            builder.Property(person => person.LastName)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(person => person.City)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(person => person.Street)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(person => person.StreetNumber)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(person => person.ZipCode)
                .HasMaxLength(5)
                .IsRequired();

            builder.HasMany(person => person.Tickets)
                .WithOne(ticket => ticket.Person)
                .HasForeignKey(ticket => ticket.PersonId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
