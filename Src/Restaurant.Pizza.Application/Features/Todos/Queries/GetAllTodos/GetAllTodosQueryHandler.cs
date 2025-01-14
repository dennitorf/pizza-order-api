﻿using AutoMapper;
using Restaurant.Pizza.Persistence.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant.Pizza.Application.Features.Todos.Queries.GetAllTodos
{
    public class GetAllTodosQueryHandler : IRequestHandler<GetAllTodosQuery, IEnumerable<TodoDto>>
    {
        private AppDbContext db;
        private ILogger logger;
        private IMapper mapper;

        public GetAllTodosQueryHandler(AppDbContext db, ILogger<GetAllTodosQueryHandler> logger, IMapper mapper)
        {
            this.db = db;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TodoDto>> Handle(GetAllTodosQuery request, CancellationToken cancellationToken)
        {
            return mapper.ProjectTo<TodoDto>(db.Todos.AsNoTracking());
        }
    }
}
