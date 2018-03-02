using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoMvc.Models;

namespace TodoMvc.Services
{
        public class FakeToDoItemService : ITodoItemService
        {
            public Task<IEnumerable<TodoMvc.Models.ToDoItem>> GetIncompleteItemsAsync()
            {
                IEnumerable<TodoMvc.Models.ToDoItem> items = new[]
                {
                    new TodoMvc.Models.ToDoItem
                    {
                        Title = "Learn Asp.Net Core",
                        DueAt = DateTimeOffset.Now.AddDays(1)
                    },
                    new TodoMvc.Models.ToDoItem
                    {
                        Title = "Build Awsome apps",
                        DueAt = DateTimeOffset.Now.AddDays(2)
                    }
                };

                return Task.FromResult(items);
            }
        }
}
