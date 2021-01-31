using CMS.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace CMS.Infrastructure.MsSQL.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(eve => eve.ID);

            builder.Property(x => x.Pseudonym)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Message)
                .HasMaxLength(512)
                .IsRequired();

            builder.HasData(new List<Comment>()
            {
                new Comment()
                {
                    ID = 1,
                    Pseudonym = "Alan B.",
                    Message = "We adored your festival. What a feast of music and in such a wonderful setting.",
                    Date = new System.DateTime(2021, 1, 12),
                    EventId = 1
                },
                 new Comment()
                {
                    ID = 2,
                    Pseudonym = "Mark Alabama",
                    Message = "The music was absolutely world class :))",
                    Date = new System.DateTime(2021, 1, 13),
                    EventId = 1
                },
                  new Comment()
                {
                    ID = 3,
                    Pseudonym = "XY from Toronto",
                    Message = "We adored your festival. What a feast of music and in such a wonderful setting.",
                    Date = new System.DateTime(2021, 1, 15),
                    EventId = 2
                },
                   new Comment()
                {
                    ID = 4,
                    Pseudonym = "Paweł",
                    Message = "I think it’s the best weekend of the year! Yesterday’s concert was a triumph and the playing quite exceptional.",
                    Date = new System.DateTime(2021, 1, 16),
                    EventId = 2
                },
                    new Comment()
                {
                    ID = 5,
                    Pseudonym = "Adam Nowak",
                    Message = "Last night was a superb example of music making at its very best. The entire evening would grace any concert hall in the country.",
                    Date = new System.DateTime(2021, 1, 17),
                    EventId = 3
                },
                     new Comment()
                {
                    ID = 6,
                    Pseudonym = "Monika",
                    Message = "A simply wonderful evening– the music was breath taking – I can’t believe how lucky we are to have such extraordinarily talented young musicians – it was a superb way to start the week!",
                    Date = new System.DateTime(2021, 1, 18),
                    EventId = 3
                },
                      new Comment()
                {
                    ID = 7,
                    Pseudonym = "Luna",
                    Message = "As we entered your glorious garden we knew we were in for a treat and what a treat! Absolute bliss - I think we were in paradise!",
                    Date = new System.DateTime(2021, 1, 19),
                    EventId = 3
                },
            });
        }
    }
}
