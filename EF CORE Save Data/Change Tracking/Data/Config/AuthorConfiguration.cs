﻿public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();

        builder.Property(x => x.FName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50).IsRequired();

        builder.Property(x => x.LName)
       .HasColumnType("VARCHAR")
       .HasMaxLength(50).IsRequired();

        builder.ToTable("Authors");
    }
}
