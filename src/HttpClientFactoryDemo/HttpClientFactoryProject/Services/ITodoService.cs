using HttpClientFactoryProject.Models;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Services
{
    public interface ITodoService
    {
        Task<TodoModel> GetTodo(int id);
    }
}
