using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoServicesCore.Models;

namespace TodoServicesCore.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context; 


        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public void Add(Todo item)
        {
            throw new NotImplementedException();
        }

        public Todo Find(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetAll()
        {
            return _context.Todo.ToList();
        }

        public void Remove(int key)
        {
            throw new NotImplementedException();
        }

        public void Update(Todo item)
        {
            throw new NotImplementedException();
        }
    }
}
