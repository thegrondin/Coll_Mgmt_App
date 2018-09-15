using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coll_Mgmt_App.Services.DataService.Base
{
    public interface IRestService
    {
        Task<T> RefreshAsync<T>(Uri uri);
        Task<bool> AddAsync<T>(Uri uri, T item);
        Task<bool> DeleteAsync<T>(Uri uri, string id);

    }
}
