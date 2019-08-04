using System.Collections.Generic;
using RestApiDOTNETCore.Data;
using RestApiDOTNETCore.Models;
using RestApiDOTNETCore.Repositories;

namespace PersonRepository.Repositories.impl{
  public class PersonRepositoryImpl : IPersonRepository
  {
    private readonly DataBaseContext _databaseContext;
    public PersonRepositoryImpl(DataBaseContext dataBaseContext){
      _databaseContext = dataBaseContext;
    }

    public Person CreatePerson(Person person)
    {
      var savedPerson = _databaseContext.Person.Add(person);
      _databaseContext.SaveChanges();
      return savedPerson.Entity;
    }

    public IEnumerable<Person> FindAllPersons()
    {
      return _databaseContext.Person;
    }
  }
}