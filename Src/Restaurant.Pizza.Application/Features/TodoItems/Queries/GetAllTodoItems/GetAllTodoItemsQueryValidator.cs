﻿using FluentValidation;

namespace Restaurant.Pizza.Application.Features.TodoItems.Queries.GetAllTodoItems
{
    public class GetAllTodoItemsQueryValidator : AbstractValidator<GetAllTodoItemsQuery>
    {
        public GetAllTodoItemsQueryValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty()
                .NotNull()
                .NotEqual(0)
                .WithMessage("Id is required");
        }
    }
}
