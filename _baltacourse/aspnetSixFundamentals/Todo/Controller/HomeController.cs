using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controller;

[ApiController]


public class HomeController : ControllerBase
{
    [HttpGet("/")]
    
    public List<TodoModel> Get([FromServices] AppDbContext context)
    {
        return context.Todos.ToList();
    }
    
    [HttpGet("/{id:int}")]
    
    public TodoModel GetById(
        [FromRoute] int id,
        [FromServices] AppDbContext context)
    {

        return context.Todos.FirstOrDefault(x => x.Id == id);
    }

    
    
    [HttpPost("/")]
    
    public TodoModel Post(
        [FromBody] TodoModel todo,
        [FromServices] AppDbContext context
    )
    {
        context.Todos.Add(todo);
        context.SaveChanges();
        return todo;
    }
    
    [HttpPut("/{id:int}")]
    public IActionResult Put(
        [FromRoute] int id,
        [FromBody] TodoModel todo,
        [FromServices] AppDbContext context
    )
    {
        // Verifica se o item com o ID fornecido existe no banco de dados
        var existingTodo = context.Todos.FirstOrDefault(x => x.Id == id);
    
        if (existingTodo == null)
        {
            return NotFound(); // Retorna 404 se o item não for encontrado
        }

        // Garante que o ID do objeto a ser atualizado seja o mesmo da rota
        todo.Id = id;

        // Atualiza os dados no contexto e salva as alterações
        context.Entry(existingTodo).CurrentValues.SetValues(todo);
        context.SaveChanges();

        // Retorna o objeto atualizado
        return Ok(todo);
    }
    
    
    [HttpDelete("/{id:int}")]
    public IActionResult Delete(
        [FromRoute] int id,
        [FromServices] AppDbContext context
    )
    {
        // Verifica se o item com o ID fornecido existe no banco de dados
        var existingTodo = context.Todos.FirstOrDefault(x => x.Id == id);
    
        if (existingTodo == null)
        {
            return NotFound(); // Retorna 404 se o item não for encontrado
        }

        
        context.Todos.Remove(existingTodo);
        context.SaveChanges();
        
        
        return Ok(existingTodo);
    }

}