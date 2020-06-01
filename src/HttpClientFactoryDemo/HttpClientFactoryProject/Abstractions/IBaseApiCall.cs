using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Abstractions
{
    public interface IBaseApiCallAsync<T>
    {
        [Get("{id}")]
        Task<IEnumerable<T>> Get();

        [Get("get/{id}")]
        Task<IEnumerable<T>> Get(int id);

        [Post("post")]
        Task CreateAsync([Body]T entity);

        [Put("update/{id}")]
        Task UpdateAsync(int id, [Body]T entity);

        [Delete("delete/{id}")]
        Task Delete(int id);
    }
}
