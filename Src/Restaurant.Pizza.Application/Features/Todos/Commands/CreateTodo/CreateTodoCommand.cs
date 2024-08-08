using Restaurant.Pizza.Application.Features.Todos.Queries.GetAllTodos;
using MediatR;

namespace Restaurant.Pizza.Application.Features.Todos.Commands.CreateTodo
{
    public class CreateTodoCommand : IRequest<TodoDto>
    {
        public string Name { set; get; }
    }
}
