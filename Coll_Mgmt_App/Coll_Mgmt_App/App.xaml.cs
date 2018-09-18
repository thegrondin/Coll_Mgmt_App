using System;
using Xamarin.Forms;
using Coll_Mgmt_App.Views;
using Xamarin.Forms.Xaml;
using Coll_Mgmt_App.Models;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Coll_Mgmt_App
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();


			MainPage = new MainPage();

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
