using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlantGuide.Business.Exceptions;
using PlantGuide.Business.Services.Base;

namespace PlantGuide.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CrudBaseController<T,TDTO> : ControllerBase
    where T : class
    where TDTO : class
{
    private readonly ICrud<T, TDTO> _service;
    public CrudBaseController(ICrud<T, TDTO> service)
    {
        _service = service;
    }
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var data = await _service.GetAllAsync();
            if (data != null)
            {
                return Ok(data);
            }
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        return NoContent();
    }

    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var data = await _service.GetAsync(id);
            if (data != null)
            {
                return Ok(data);
            }
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (Exception)
        {
            throw;
        }

        return NoContent();
    }
    public async Task<IActionResult> Post(TDTO model)
    {
        var data = await _service.AddAsync(model);
        return Ok(data);
    }
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
    public async Task<IActionResult> Update(int id, TDTO DTO)
    {
        var data = await _service.UpdateByIdAsync(id, DTO);
        return Ok(data);
    }

}
