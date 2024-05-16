﻿public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();

        builder.Property(x => x.Title)
            .HasColumnType("VARCHAR")
            .HasMaxLength(255).IsRequired();

        builder.HasOne(x => x.Author)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.AuthorId)
            .IsRequired();

        builder.Property(x => x.Price)
            .HasColumnType("decimal(18, 2)").IsRequired();

        builder.ToTable("Books");
    }
}
