﻿using Restaurant.Pizza.Application.Common.Interfaces.Mappings;
using Restaurant.Pizza.Domain.Entities.Sample;
using System;

namespace Restaurant.Pizza.Application.Features.Todos.Queries.GetAllTodos
{
    public class TodoDto : IMapFrom<Todo>
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsActive { set; get; }
    }
}