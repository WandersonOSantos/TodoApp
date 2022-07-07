using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsDoneCommand : Notifiable, ICommand
    {
        public Guid Id { get; set; }
        public string User { get; set; }

        public MarkTodoAsDoneCommand()
        {
            
        }

        public MarkTodoAsDoneCommand(Guid id, string user)
        {
            User = user;
            Id   = id;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(User, 6, "User", "Usuário inválido!")
            );
        }
    }
}