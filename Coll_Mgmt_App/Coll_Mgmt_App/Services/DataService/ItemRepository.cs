using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coll_Mgmt_App.Services.DataService
{
    public interface IItemRepository<T>
    {
        Task<bool> AddItemAsync(T collection);
        Task<bool> RemoveItemnAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<T> GetFieldsFromItem(string id, List<string> fields);
        Task<IEnumerable<T>> GetItemsAsync();
        Task<IEnumerable<object>> GetFieldsFromItems(List<string> fields);
    }
}
