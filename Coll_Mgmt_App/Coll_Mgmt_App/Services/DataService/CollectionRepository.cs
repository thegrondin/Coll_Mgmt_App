using Coll_Mgmt_App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coll_Mgmt_App.Services.DataService
{
    class CollectionRepository : ICollectionRepository<CollectionModel>
    {
        public Task<bool> AddCollectionAsync(CollectionModel collection)
        {
            throw new NotImplementedException();
        }

        public Task<CollectionModel> GetCollectionAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CollectionModel>> GetCollectionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CollectionModel> GetFieldsFromCollection(string id, List<string> fields)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetFieldsFromCollections(List<string> fields)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveCollectionAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
