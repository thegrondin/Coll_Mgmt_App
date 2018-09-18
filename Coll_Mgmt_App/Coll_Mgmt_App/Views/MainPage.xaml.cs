using Coll_Mgmt_App.Models;
using Coll_Mgmt_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coll_Mgmt_App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
	{
        private NavigationViewModel _navigationViewModel;
		public MainPage ()
		{
            

            InitializeComponent ();

            _navigationViewModel = new NavigationViewModel();

            BindingContext = _navigationViewModel;

            masterPage.listView.ItemSelected += OnItemSelected;
        }


        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _navigationViewModel.ChangeMasterDetailCommand.Execute(e.SelectedItem);
            Detail = _navigationViewModel.CurrentPage;
        }
    }
}
