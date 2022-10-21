using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormularioDinamico.ViewModels;

namespace XamarinFormularioDinamico.Views
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