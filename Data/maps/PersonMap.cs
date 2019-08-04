using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiDOTNETCore.Models;

namespace RestApiDOTNETCore.Data.maps{
  public class PersonMap : IEntityTypeConfiguration<Person>
  {
    public void Configure(EntityTypeBuilder<Person> builder)
    {
      builder.ToTable("Person");
      builder.HasKey( x => x.Id);
      builder.Property( x => x.FirstName).IsRequired().HasColumnType("varchar(1024)");
      builder.Property( x => x.LastName).IsRequired().HasColumnType("varchar(1024)");
      builder.Property(x => x.Address).IsRequired().HasColumnType("varchar(1024");
      builder.Property(x => x.Gender).IsRequired().HasColumnType("varchar(1024");
    }
  }
}