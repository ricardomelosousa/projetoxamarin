using Projeto.StartupOne.IHistory.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Projeto.StartupOne.IHistory.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}