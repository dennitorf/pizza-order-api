using Restaurant.Pizza.Application.Features.Todos.Queries.GetAllTodos;
using MediatR;

namespace Restaurant.Pizza.Application.Features.Todos.Commands.UpdateTodo
{
    public class UpdateTodoCommand : IRequest<TodoDto>
    {
        public int Id { get; set; } 
        public string Name { set; get; }
    }
}
