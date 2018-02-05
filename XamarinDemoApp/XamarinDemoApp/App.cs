using System;
using XamarinDemoApp.Helpers;
using XamarinDemoApp.Models;
using XamarinDemoApp.Services;

namespace XamarinDemoApp
{
    public class App
    {
		public static bool UseMockDataStore = true;
		public static string AzureMobileAppUrl = "https://[CONFIGURE-THIS-URL].azurewebsites.net";

        public static void Initialize()
        {
            if (UseMockDataStore)
				ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
			else
                ServiceLocator.Instance.Register<IDataStore<Item>, AzureDataStore>();
        }
    }
}
