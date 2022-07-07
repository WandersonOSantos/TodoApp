using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class GenericComandResult: ICommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}