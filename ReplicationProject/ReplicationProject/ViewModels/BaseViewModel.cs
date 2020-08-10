using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using ReplicationProject.Models;
using ReplicationProject.Services;

namespace ReplicationProject.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<AplicativoModel> DataStore => DependencyService.Get<IDataStore<AplicativoModel>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }

            set
            {
                isBusy = value;
                Notify(nameof(IsBusy));
            }
        }

        protected void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected string titulo;
        public string Titulo
        {
            get => titulo;
            set
            {
                titulo = value;
                Notify(nameof(Titulo));
            }
        }
    }
}
