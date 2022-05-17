using System.ComponentModel;
using Xamarin.Forms;
using Zhukova_PR20.ViewModels;

namespace Zhukova_PR20.Views
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