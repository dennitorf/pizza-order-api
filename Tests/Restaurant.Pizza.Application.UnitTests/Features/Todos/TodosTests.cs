using NUnit.Framework;
using Restaurant.Pizza.Application.UnitTests.Mocks.Persistence;
using Restaurant.Pizza.Persistence.Contexts;
using Restaurant.Pizza.Application.Features.Todos.Commands.CreateTodo;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Threading;
using Restaurant.Pizza.Application.Common.Exceptions;
using Restaurant.Pizza.Application.Features.Todos.Commands.UpdateTodo;
using NUnit.Framework.Legacy;

namespace Restaurant.Pizza.Application.UnitTests.Features.Todos 
{
    public class TodosTests
    {
        private AppDbContext db {set; get; }   
        private ILoggerFactory factory;        

        public TodosTests()
        {
            this.db = AppplicationDbContextMock.appDbContext;
            
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();        

            factory = serviceProvider.GetService<ILoggerFactory>();                                        
        }

        [Test]
        public async Task CreateTodoWithParameters()
        {
            var command = new CreateTodoCommand() { Name = "My todo 1" }; 
            var handler = new CreateTodoCommandHandler(AutoMapperMock.mapper, db, factory.CreateLogger<CreateTodoCommandHandler>());

            var obj = await handler.Handle(command, new CancellationToken());

            ClassicAssert.AreEqual(obj.Name, "My todo 1");            
        }

        [Test]
        public async Task CreateTodoWithoutParameters()
        {
            // var command = new CreateTodoCommand() {  }; 
            // var handler = new CreateTodoCommandHandler(AutoMapperMock.mapper, db, factory.CreateLogger<CreateTodoCommandHandler>());
            // Assert.ThrowsAsync<ValidationException>(async () => await handler.Handle(command, new CancellationToken()));                    
        }

        [Test]
        public async Task UpdateTodo()
        {
            var command = new UpdateTodoCommand() { Id = 1, Name = "My todo 2" }; 
            var handler = new UpdateTodoCommandHandler(factory.CreateLogger<UpdateTodoCommandHandler>(), db, AutoMapperMock.mapper);

            var obj = await handler.Handle(command, new CancellationToken());

            ClassicAssert.AreEqual(obj.Name, "My todo 2");            
        }

        [Test]
        public async Task UpdateNonExistingTodo()
        {
            var command = new UpdateTodoCommand() { Id = 90, Name = "My todo 2" }; 
            var handler = new UpdateTodoCommandHandler(factory.CreateLogger<UpdateTodoCommandHandler>(), db, AutoMapperMock.mapper);            
            Assert.ThrowsAsync<NotFoundException>(async () => await handler.Handle(command, new CancellationToken()));                    
        }        
    }
}

