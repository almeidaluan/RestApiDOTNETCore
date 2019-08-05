using System;
using System.Collections.Generic;
using RestApiDOTNETCore.Models;

namespace RestApiDOTNETCore.Services{
  public interface IPersonService{

    Person Create(Person person);
    Person FindById(Guid id);
    List<Person> FindAll();
    Person update(Person person); 
    void Delete(Guid id);
    
  }
}