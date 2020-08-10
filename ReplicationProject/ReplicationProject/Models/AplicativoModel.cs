using System;
using Xamarin.Forms;

namespace ReplicationProject.Models
{
    public class AplicativoModel
    {
        public int Id { get; set; }
        public string Aplicativo { get; set; }
        public string Descrição { get; set; }
        public DateTime Data { get; set; }
        public Color ContentViewColor { get; set; }
        public ImageSource Icon { get; set; }
    }
}