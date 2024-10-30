using Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers;

[ApiController]

public class CategoryController : ControllerBase
{
    [HttpGet("categories")]
    public async Task<IActionResult> GetAsync(
        [FromServices] BlogDataContext context)
    {
        var categories =  await context.Categories.ToListAsync();
        return Ok(categories);
    }
    
    
    [HttpGet("categories/{id:int}")]
    public async Task<IActionResult> GetAsync(
        [FromRoute] int id,
        [FromServices] BlogDataContext context)
    {
    
    
        var category =  await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        return Ok(category);
    }
}