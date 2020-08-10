using ReplicationProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ReplicationProject.Projects.Alelo.ViewModels
{
    public class AleloInicioViewModel : BaseViewModel
    {
        #region Commands

        public Command OndeAceitaCommand { get; }
        public Command ExtratoCommand { get; }
        public Command DescontosVantagensCommand { get; }
        public Command AdicionarCartaoCommand { get; }
        public Command AjudaCommand { get; }
        public Command DeliveryCommand { get; }

        #endregion

        public AleloInicioViewModel()
        {
            OndeAceitaCommand = new Command(() => ExecuteOndeAceitaCommand());
            ExtratoCommand = new Command(() => ExecuteExtratoCommand());
            DescontosVantagensCommand = new Command(() => ExecuteDescontosVantagensCommand());
            AdicionarCartaoCommand = new Command(() => ExecuteAdicionarCartaoCommand());
            AjudaCommand = new Command(() => ExecuteAjudaCommand());
            DeliveryCommand = new Command(() => ExecuteDeliveryCommand());
        }

        #region Metodos

        private void ExecuteDeliveryCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteAjudaCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteAdicionarCartaoCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteDescontosVantagensCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteExtratoCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteOndeAceitaCommand()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
