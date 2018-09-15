using Coll_Mgmt_App.Models;
using Coll_Mgmt_App.Services.DataService;
using Coll_Mgmt_App.Services.DataService.Base;
using Coll_Mgmt_App.ViewModels;
using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coll_Mgmt_App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
            BindingContext = new CollectionViewModel(
                new CollectionRepository<CollectionModel>(
                    new RestService(
                        new HttpClient()), 
                        new Uri("http://localhost:13383/api/collection/")
                    )
                );

			InitializeComponent ();
		}
	}
}