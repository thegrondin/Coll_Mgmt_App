using Coll_Mgmt_App.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Coll_Mgmt_App.ViewModels
{
    class NavigationViewModel : BaseViewModel
    {
        public ICommand ChangeMasterDetailCommand { get; set; }
        public NavigationPage CurrentPage { get; set; }
        public NavigationViewModel()
        {
            ChangeMasterDetailCommand = new Command(async (masterPageItem) => await ExecuteChangeMasterDetailCommand(masterPageItem));
        }

        async Task ExecuteChangeMasterDetailCommand(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                MasterPageItem item = obj as MasterPageItem;

                if (item != null)
                {
                    CurrentPage = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
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
