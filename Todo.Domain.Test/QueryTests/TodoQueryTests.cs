using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Test.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "usuarioA", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "usuarioB", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "usuario.teste", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "usuarioD", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "usuario.teste", DateTime.Now));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_wandersonosantos()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("usuario.teste"));
            Assert.AreEqual(2, result.Count());
        }
    }
}