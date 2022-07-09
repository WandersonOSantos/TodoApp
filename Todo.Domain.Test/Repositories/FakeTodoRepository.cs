
using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Test.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {
        }

        public TodoItem GetById(Guid id, string email)
        {
            return new TodoItem("Titulo Aqui", "wanderson.osantos", DateTime.Now);
        }

        public void Update(TodoItem todo)
        {
        }
    }
}