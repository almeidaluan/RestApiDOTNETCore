using System;

namespace RestApiDOTNETCore.Models{
  public class Person{
    
    public Person()
    {
      Id = Guid.NewGuid();
    }

    public Guid Id { get;set;}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    public string Gender { get; set; }
  }
}