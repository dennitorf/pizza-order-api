﻿using AutoMapper;
using Restaurant.Pizza.Application.Features.Todos.Queries.GetAllTodos;
using Restaurant.Pizza.Domain.Entities.Sample;
using Restaurant.Pizza.Persistence.Contexts;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant.Pizza.Application.Features.Todos.Commands.CreateTodo
{
    public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, TodoDto>
    {
        private IMapper mapper;
        private AppDbContext db;
        private ILogger logger;

        public CreateTodoCommandHandler(IMapper mapper, AppDbContext db, ILogger<CreateTodoCommandHandler> logger)
        {
            this.mapper = mapper;
            this.db = db;
            this.logger = logger;
        }

        public async Task<TodoDto> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var ent = new Todo() 
            { 
                Name = request.Name,
                CreatedBy = "system",
                CreatedDate = DateTime.UtcNow,
                LastModifiedBy = "system",
                ModifiedDate = DateTime.UtcNow,
                IsActive = true                    
            };

            await db.Todos.AddAsync(ent);
            await db.SaveChangesAsync(cancellationToken);

            return mapper.Map<TodoDto>(ent);
        }
    }
}
