using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coll_Mgmt_App.Services.DataService
{
    public interface ICollectionRepository<T>
    {
        Task<bool> AddCollectionAsync(T collection);
        Task<bool> RemoveCollectionAsync(string id);
        Task<T> GetCollectionAsync(string id);
        Task<T> GetFieldsFromCollection(string id, List<string> fields);
        Task<IEnumerable<T>> GetCollectionsAsync();
        Task<IEnumerable<object>> GetFieldsFromCollections(List<string> fields);
    }
}
