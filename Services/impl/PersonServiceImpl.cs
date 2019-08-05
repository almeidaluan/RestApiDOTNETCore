using System;
using System.Collections.Generic;
using RestApiDOTNETCore.Models;
using RestApiDOTNETCore.Repositories;

namespace RestApiDOTNETCore.Services.impl{
  public class PersonServiceImpl : IPersonService
  {
    private readonly IPersonRepository _iPersonRepository;
    public PersonServiceImpl(IPersonRepository iPersonRepository){
      _iPersonRepository = iPersonRepository;
    }

    public Person Create(Person person)
    {
      return _iPersonRepository.CreatePerson(person);
    }

    public void Delete(Guid id)
    {
      throw new NotImplementedException();
    }

    public List<Person> FindAll()
    {
      return _iPersonRepository.FindAllPersons();
    }

    public Person FindById(Guid id)
    {
      return _iPersonRepository.findById(id);
    }

    public Person update(Person person)
    {
      throw new NotImplementedException();
    }
  }
}