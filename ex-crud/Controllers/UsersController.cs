using ex_crud.IO;
using ex_crud.Models;
using ex_crud.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace ex_crud.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult <CreateUserOutput>> Post([FromBody]CreateUserInput input)
    {
        var useCase = new CreateUserUseCase();
        var response = useCase.Execute(input);
        return Ok(response);
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult <GetUserOutput>> Get(Guid id)
    {
        var useCase = new GetUserUseCase();
        var response = useCase.Execute(id);
        return Ok(response);

    }

    [HttpGet]
    public async Task<ActionResult<GetUserOutput>> GetAll()
    {
        var response = UserStore.Users.ToList();
        return Ok(response);

    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id)
    {
        // substitui o recurso existente pela nova versão fornecida
        return NoContent();
    }

    //[HttpPatch("{id:int}")]
    //public async Task<ActionResult> Patch(int id)
    //{
    //    // o cliente envia apenas as alterações desejadas
    //    return NoContent();
    //}

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        return NoContent();
    }
}
