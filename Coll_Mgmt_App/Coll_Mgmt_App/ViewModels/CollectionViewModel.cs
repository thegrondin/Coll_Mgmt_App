using Coll_Mgmt_App.Models;
using Coll_Mgmt_App.Services.DataService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Coll_Mgmt_App.ViewModels
{

    class CollectionViewModel : BaseViewModel
    {
        private ICollectionRepository<CollectionModel> _collectionRepository;

        public ObservableCollection<string> CollectionsName { get; set; }
        public Command LoadCollectionsNameCommand { get; set; }

        public CollectionViewModel(ICollectionRepository<CollectionModel> collectionRepository)
        {
            CollectionsName = new ObservableCollection<string>();
            LoadCollectionsNameCommand = new Command(async () => await ExecuteLoadCollectionsNameCommand());
            _collectionRepository = collectionRepository;
        }

        async Task ExecuteLoadCollectionsNameCommand()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                CollectionsName.Clear();

                IEnumerable<object> collectionsName = await _collectionRepository.GetFieldsFromCollections(new List<string>() { "Name" });

                foreach(var obj in collectionsName)
                {
                    PropertyInfo pi = obj.GetType().GetProperty("Name");
                    CollectionsName.Add((string)pi.GetValue(obj, null));
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
