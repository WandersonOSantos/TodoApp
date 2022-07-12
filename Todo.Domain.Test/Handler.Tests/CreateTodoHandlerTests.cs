
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Test.Repositories;

namespace Todo.Domain.Test.Handler.Tests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Título da tarefa","usuario.teste", DateTime.Now);
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result;

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _result  = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Success, false);
        }

        [TestMethod]
        public void Dado_um_comando_invalido_deve_criar_a_tarefa()
        {
            var _result  = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Success, true);
        }
    }
}