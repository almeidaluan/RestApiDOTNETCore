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

    private readonly PersonConverter _personConverter;
    public PersonController(IPersonService iPersonService){
      _personService = iPersonService;
      _personConverter = new PersonConverter();
    }

    [HttpGet("persons")]
    public IActionResult findAllPersons(){
      return Ok(_personConverter.ParseList(_personService.FindAll()));
    }

    [HttpGet("persons/{id}")]
    public IActionResult findById(Guid id){
      
      Person person = _personService.FindById(id);
      return Ok(_personConverter.Parse(person)); 
    
    }

    [HttpPost("persons")]
    public IActionResult createPerson([FromBody]Person person){
      return Ok(_personService.Create(person));
    }
  }
}