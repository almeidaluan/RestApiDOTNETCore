using Microsoft.EntityFrameworkCore;
using RestApiDOTNETCore.Data.maps;
using RestApiDOTNETCore.Models;

namespace RestApiDOTNETCore.Data{
  public class DataBaseContext: DbContext{

    public DbSet<Person> Person {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
      
      optionsBuilder.UseInMemoryDatabase();
    
    }

    protected override void OnModelCreating(ModelBuilder builder){
      builder.ApplyConfiguration(new PersonMap());
    }


  }
}