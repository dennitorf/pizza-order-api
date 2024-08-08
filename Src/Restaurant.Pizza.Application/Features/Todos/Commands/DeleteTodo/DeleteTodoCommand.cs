using MediatR;

namespace Restaurant.Pizza.Application.Features.Todos.Commands.DeleteTodo
{
    public class DeleteTodoCommand : IRequest
    {
        public int Id { set; get; }
    }
}
