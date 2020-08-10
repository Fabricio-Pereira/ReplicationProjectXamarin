using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReplicationProject.Services;
using ReplicationProject.Views;
using ReplicationProject.Projects.Alelo.Views;
using ReplicationProject.Models;



namespace ReplicationProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            //MainPage = new NavigationPage(new Alelo(DependencyService.Get<IDataStore<AplicativoModel>>().GetUsuario()));

            MainPage = new MenuProject();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
