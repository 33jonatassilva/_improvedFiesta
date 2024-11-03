using Blog.Data;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers;

[ApiController]

public class CategoryController : ControllerBase
{
<<<<<<< HEAD
    [HttpGet("v1/categories/{id:int}")]
    public async Task<IActionResult> GetAsync(
        [FromRoute] int id,
        [FromServices] BlogDataContext context)
    {
        var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
       
        if (category == null)
            return NotFound();
        
        return Ok(category);
    }
    
    [HttpGet("v1/categories/all")]
    public async Task<IActionResult> GetAllAsync(
        [FromServices] BlogDataContext context)
    {
        var category = await context.Categories.ToListAsync();
        
        return Ok(category);
    }
    
    
    [HttpPost("v1/categories")]
    public async Task<IActionResult> PostAsync(
        [FromBody] EditorCategoryViewModel auxModel,
        [FromServices] BlogDataContext context)
    {
        try
        {
            var model = new Category
            {
                Name = auxModel.Name,
                Slug = auxModel.Slug.ToLower(),
            };
            
            await context.Categories.AddAsync(model);
            await context.SaveChangesAsync();

            return Created($"v1/categories/{model.Id}", model);
        }
        catch (DbUpdateException ex)
        {
            return StatusCode(500, "Não foi possível incluir a categoria\nErro: " + ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    
    [HttpPut("v1/categories/{id:int}")]
    public async Task<IActionResult> PutAsync(
        [FromRoute] int id, 
        [FromBody] Category model,
        [FromServices] BlogDataContext context)
    {
        var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        
        if (category == null)
            return NotFound();
        
        category.Name = model.Name;
        category.Slug = model.Slug;
        
        context.Categories.Update(category);
        await context.SaveChangesAsync();
        
        return Ok(model);
    }
    
    [HttpDelete("v1/categories/{id:int}")]
    public async Task<IActionResult> DeleteAsync(
        [FromRoute] int id,
        [FromServices] BlogDataContext context)
    {
        var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
       
        if (category == null)
            return NotFound();
        
        context.Categories.Remove(category);
        
        return Ok(category);
=======
    [HttpGet("categories")]
    public async Task<IActionResult> GetAsync(
        [FromServices] BlogDataContext context)
    {
        var categories =  await context.Categories.ToListAsync();
        return Ok(categories);
>>>>>>> e621fb7b79c47146d98a2237b042694bea6f7108
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