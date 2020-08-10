using ReplicationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReplicationProject.Projects.Alelo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alelo : Naxam.Controls.Forms.BottomTabbedPage
    {
        public Alelo(UsuarioModel usuario)
        {
            InitializeComponent();

            this.AletoTitulo.Text = $"Olá {usuario.Primeiro_Nome} =)";
        }
    }
}