using RTask.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RTask.Views
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