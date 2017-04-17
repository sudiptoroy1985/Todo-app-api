using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoServicesCore.Models;
using Microsoft.EntityFrameworkCore;
using TodoServicesCore.Repository;

namespace TodoServicesCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Todo")]
    public class TodoController : Controller 
    {
        private readonly ITodoRepository _repository;

        public TodoController(ITodoRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Todo
        [HttpGet]
        public IEnumerable<Todo> GetTodos()
        {
            return _repository.GetAll();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodo([FromRoute] int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //var todo = await _context.Todo.SingleOrDefaultAsync(m => m.Id == id);

            //if (todo == null)
            //{
            //    return NotFound();
            //}

            //return Ok(todo);

            return null;
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodo([FromRoute] int id, [FromBody] Todo todo)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != todo.Id)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(todo).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!TodoExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return NoContent();
        }

        // POST: api/Todo
        [HttpPost]
        public async Task<IActionResult> PostTodo([FromBody] Todo todo)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //_context.Todo.Add(todo);
            //await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodo", new { id = todo.Id }, todo);
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo([FromRoute] int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //var todo = await _context.Todo.SingleOrDefaultAsync(m => m.Id == id);
            //if (todo == null)
            //{
            //    return NotFound();
            //}

            //_context.Todo.Remove(todo);
            //await _context.SaveChangesAsync();

            //return Ok(todo);

            return null;
        }

        private bool TodoExists(int id)
        {
            //return _context.Todo.Any(e => e.Id == id);

            return true;
        }
    }
}