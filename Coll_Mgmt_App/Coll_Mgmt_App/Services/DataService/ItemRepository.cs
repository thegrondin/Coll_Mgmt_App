using Coll_Mgmt_App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coll_Mgmt_App.Services.DataService
{
    class ItemRepository : IItemRepository<Item>
    {
        public Task<bool> AddItemAsync(Item collection)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetFieldsFromItem(string id, List<string> fields)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetFieldsFromItems(List<string> fields)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Item>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveItemnAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
