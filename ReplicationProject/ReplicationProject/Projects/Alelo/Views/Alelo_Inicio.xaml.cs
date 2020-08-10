using ReplicationProject.Projects.Alelo.ViewModels;
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
    public partial class Alelo_Inicio : ContentPage
    {
        public Alelo_Inicio()
        {
            InitializeComponent();

            BindingContext = new AleloInicioViewModel();
        }
    }
}