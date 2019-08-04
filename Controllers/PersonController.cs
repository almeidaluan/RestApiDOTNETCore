using System;
using Microsoft.AspNetCore.Mvc;
using RestApiDOTNETCore.Models;
using RestApiDOTNETCore.Services;

namespace RestApiDOTNETCore.Controllers{

  [Route("v1/api")]
  public class PersonController: Controller{

    private readonly IPersonService _personService;
    public PersonController(IPersonService iPersonService){
      _personService = iPersonService;
    }

    [HttpGet("persons")]
    public IActionResult findAllPersons(){
      return Ok(_personService.FindAll());
    }

    [HttpPost("persons")]
    public IActionResult createPerson([FromBody]Person person){
      return Ok(_personService.Create(person));
    }
  }
}