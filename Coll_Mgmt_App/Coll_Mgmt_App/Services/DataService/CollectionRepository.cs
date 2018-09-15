using Coll_Mgmt_App.Services.DataService.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coll_Mgmt_App.Services.DataService
{
    public class CollectionRepository<CollectionModel> : ICollectionRepository<CollectionModel>
    {
        IRestService _restService;
        Uri _baseUri;

        public CollectionRepository(IRestService restService, Uri baseUri)
        {
            _baseUri = baseUri;
            _restService = restService;
        }

        public Task<bool> AddCollectionAsync(CollectionModel collection)
        {
            return _restService.AddAsync(_baseUri, collection);
        }

        public Task<CollectionModel> GetCollectionAsync(string id)
        {
            return _restService.RefreshAsync<CollectionModel>(new Uri(_baseUri + id));
        }

        public Task<IEnumerable<CollectionModel>> GetCollectionsAsync()
        {
            return _restService.RefreshAsync<IEnumerable<CollectionModel>>(_baseUri);
        }

        public Task<object> GetFieldsFromCollection(string id, List<string> fields)
        {
            return _restService.RefreshAsync<object>(new Uri(_baseUri + id + "/?=" + String.Join(",", fields)));
        }

        public Task<IEnumerable<object>> GetFieldsFromCollections(List<string> fields)
        {
            return _restService.RefreshAsync<IEnumerable<object>>(new Uri(_baseUri + "?=" + String.Join(",", fields)));
        }

        public Task<bool> RemoveCollectionAsync(string id)
        {
            return _restService.DeleteAsync<CollectionModel>(_baseUri, id);
        }
    }
}
