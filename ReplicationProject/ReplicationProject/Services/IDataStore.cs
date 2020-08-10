using ReplicationProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ReplicationProject.Services
{
    public interface IDataStore<T>
    {
        ObservableCollection<T> GetAplicativo();
        UsuarioModel GetUsuario();
    }
}
