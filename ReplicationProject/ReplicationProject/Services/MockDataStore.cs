using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ReplicationProject.Models;
using Xamarin.Forms;

namespace ReplicationProject.Services
{
    public class MockDataStore : IDataStore<AplicativoModel>
    {
        public ObservableCollection<AplicativoModel> GetAplicativo()
        {
            var aplicativos = new ObservableCollection<AplicativoModel>()
            {
                new AplicativoModel
                {
                    Id = 1,
                    Aplicativo = "Alelo",
                    Descrição = "Primeira Tela a ser replicada",
                    Data = Convert.ToDateTime("23/06/2020"),
                    ContentViewColor = Xamarin.Forms.Color.FromHex("#bdd753"),
                    Icon = ImageSource.FromFile("alelo.png")
                }
            };

            return aplicativos;
        }

        public UsuarioModel GetUsuario()
        {
            var usuario = new UsuarioModel
            {
                Primeiro_Nome = "Fabricio",
                Nome_Completo = "Fabricio Pereira",
                Descricao = "Projetos Replicados em Xamarin",
                Imagem = ImageSource.FromFile("img_perfil.png")
            };

            return usuario;
        }

    }
}