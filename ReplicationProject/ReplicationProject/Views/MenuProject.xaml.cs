using ReplicationProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReplicationProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuProject : ContentPage
    {
        public MenuProject()
        {
            InitializeComponent();

            BindingContext = new MenuProjectViewModel(this.Navigation);
        }
    }
}