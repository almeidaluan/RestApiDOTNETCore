using System.Collections.Generic;
using RestApiDOTNETCore.Models;
using RestApiDOTNETCore.VO;

namespace RestApiDOTNETCore.Converters{
  public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
  {
    public Person Parse(PersonVO origin)
    {
      if (origin == null) return null;
      return new Person{
        Id = origin.Id,
        FirstName = origin.FirstName,
        LastName = origin.LastName
      };
    }

    public PersonVO Parse(Person origin)
    {
      if (origin == null) return null;
      return new PersonVO{
        Id = origin.Id,
        FirstName = origin.FirstName,
        LastName = origin.LastName
      };
    }

    public List<Person> ParseList(List<PersonVO> origin)
    {
      throw new System.NotImplementedException();
    }

    public List<PersonVO> ParseList(List<Person> origin)
    {
      throw new System.NotImplementedException();
    }
  }
}