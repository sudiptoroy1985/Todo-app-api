using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoServicesCore.Models;

namespace TodoServicesCore.Repository
{
    public interface ITodoRepository
    {
        void Add(Todo item);
        IEnumerable<Todo> GetAll();
        Todo Find(int key);
        void Remove(int key);
        void Update(Todo item);
    }
}
