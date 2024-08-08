using MediatR;

namespace Restaurant.Pizza.Application.Features.TodoItems.Commands.DeleteTodoItem
{
    public class DeleteTodoItemCommand : IRequest
    {
        public int Id { set; get; }
    }
}
