using SmolBoii.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SmolBoii.Views
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