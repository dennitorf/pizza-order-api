using Restaurant.Pizza.Application.Features.TodoItems.Queries.GetAllTodoItems;
using MediatR;

namespace Restaurant.Pizza.Application.Features.TodoItems.Queries.GetTodoItem
{
    public class GetTodoItemQuery : IRequest<TodoItemDto>
    {
        public int Id { set; get; }
    }
}
