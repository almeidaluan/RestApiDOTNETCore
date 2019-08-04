using System;
using System.Collections.Generic;
using RestApiDOTNETCore.Models;

namespace RestApiDOTNETCore.Repositories{
  public interface IPersonRepository{

    Person CreatePerson(Person person);
    IEnumerable<Person> FindAllPersons();
    Person findById(Guid id);
  }
}