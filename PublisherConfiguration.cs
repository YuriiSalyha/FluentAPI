using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(p=> p.Id);
            builder.Property(p =>p.Name).HasDefaultValue("null");
            builder.Property(p => p.Name).HasMaxLength(50);

            builder
                .HasMany(b => b.Books)
                .WithOne(p => p.Publisher);
        }
    }
}
