using System;
using Microsoft.AspNetCore.Mvc;
using RestApiDOTNETCore.Converters;
using RestApiDOTNETCore.Models;
using RestApiDOTNETCore.Services;

namespace RestApiDOTNETCore.Controllers{

  [ApiVersion("1")]
  [Route("/v{version:apiVersion}/api")]
  public class PersonController: Controller{

    private readonly IPersonService _personService;
    public PersonController(IPersonService iPersonService){
      _personService = iPersonService;
    }

    [HttpGet("persons")]
    public IActionResult findAllPersons(){
      return Ok(_personService.FindAll());
    }

    [HttpGet("persons/{id}")]
    public IActionResult findById(Guid id){
      
      Person person = _personService.FindById(id);
      PersonConverter converter = new PersonConverter();
      return Ok(converter.Parse(person)); 
    
    }

    [HttpPost("persons")]
    public IActionResult createPerson([FromBody]Person person){
      return Ok(_personService.Create(person));
    }
  }
}