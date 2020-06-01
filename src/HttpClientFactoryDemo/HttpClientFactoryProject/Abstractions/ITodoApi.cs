using HttpClientFactoryProject.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Abstractions
{
    public interface ITodoApi
    {
        [Get("/todos")]
        Task<IEnumerable<TodoModel>> GetTodos();
    }
}
