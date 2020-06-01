using HttpClientFactoryProject.Configuration;
using HttpClientFactoryProject.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Services
{
    public class TodoService : ITodoService
    {
        private readonly IApiConfig _config;
        private readonly HttpClient _httpClient;
        public TodoService(
            IApiConfig config,
            HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<TodoModel> GetTodo(int id)
        {
            return await _httpClient.GetFromJsonAsync<TodoModel>(
                $"{_config.BaseUrl}todos/{id}"
                );
        }
    }
}
