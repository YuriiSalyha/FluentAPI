using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FluentAPI
{
    internal class BooksConfiguration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Ignore(b => b.VariableToDelete);
            builder.ToTable("BooksTable");

            builder.Property(b => b.Title).HasMaxLength(50);

            builder.Property(b => b.Price).HasDefaultValue(20);
            builder.Property(b => b.VariableToDelete).HasDefaultValue("Null");
        }
    }
}
