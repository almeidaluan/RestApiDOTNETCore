using System;

namespace RestApiDOTNETCore.Models{
  public class Person{
    private object p1;
    private object p2;
    private object p3;

    public Person()
    {
      Id = Guid.NewGuid();
    }

    public Person(object p1, object p2, object p3)
    {
      this.p1 = p1;
      this.p2 = p2;
      this.p3 = p3;
    }

    public Guid Id { get;set;}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    public string Gender { get; set; }
  }
}