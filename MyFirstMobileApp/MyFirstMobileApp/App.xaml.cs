﻿using Xamarin.Forms;
using MyFirstMobileApp.Views;
using Xamarin.Essentials;

namespace MyFirstMobileApp
{
    public partial class App : Application
    {
        //"http://myfirstmobileapp-mobileappservice.azurewebsites.net";
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address

        /// <summary>
        /// ANDROID EMULATOR SETUP- Android emulator does not run on localhost forwards from localhost to http://10.0.2.2:5000
        /// </summary>
        public static string AzureBackendUrl = 
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";

        public static bool UseMockDataStore { get; set; } = false;



       
        public App()
        {
            InitializeComponent();

            // Startup.Init instead of DependencyService.Register<IDataStore<Item>>, AzureDataStore>();
            Startup.Init();

            MainPage = new MainPage();
        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
