using MediatR;
using System.Collections.Generic;

namespace Restaurant.Pizza.Application.Features.Todos.Queries.GetAllTodos
{
    public class GetAllTodosQuery : IRequest<IEnumerable<TodoDto>>
    {
        public int Id { set; get; }

        public string Name { set; get; }
    }
}
