using ReplicationProject.Models;
using ReplicationProject.Projects.Alelo.Views;
using ReplicationProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReplicationProject.ViewModels
{
    public class MenuProjectViewModel : BaseViewModel
    {

        private ObservableCollection<AplicativoModel> _menuLista;
        public ObservableCollection<AplicativoModel> MenuLista
        {
            get => _menuLista;
            set
            {
                _menuLista = value;
                Notify(nameof(MenuLista));
            }
        }

        public AplicativoModel SelectedMenu { get; set; }

        private UsuarioModel _usuario;
        public UsuarioModel Usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
                Notify(nameof(Usuario));
            }
        }

        public Command LoadItemsCommand { get; }

        public Command ChangeSelectedItemCommand { get; }

        private INavigation Navigation { get; set; }

        public MenuProjectViewModel(INavigation navigation)
        {
            _menuLista = new ObservableCollection<AplicativoModel>();

            Navigation = navigation;

            LoadItemsCommand = new Command(() => ExecuteLoadItemsCommand());

            GetAplicativo();

            GetUsuario();
        }

        private void ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                if (SelectedMenu != null)
                {
                    this.Navigation.PushModalAsync(new Alelo(DataStore.GetUsuario()));
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

        private void GetAplicativo()
        {
            _menuLista.Clear();

            _menuLista = DataStore.GetAplicativo();

            MenuLista = _menuLista;
        }

        private void GetUsuario()
        {
            Usuario = DataStore.GetUsuario();
        }
    }
}
